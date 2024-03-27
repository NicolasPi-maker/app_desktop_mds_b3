using MAUI_Score.Interfaces;
using Newtonsoft.Json;
using System.Drawing.Printing;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MAUI_Score.Services.ModelServices
{
    public class DataManager<T> : DataManagerInterface<T> where T : class
    {
        private string _dataFile = "";
        private static readonly List<T> _items = new List<T>();
        private static int _nextId = 1;

        public DataManager(string dataFile)
        {
            _dataFile = dataFile;
        }

        public void Add(T item)
        {
            typeof(T).GetProperty("id")?.SetValue(item, _nextId++);

            List<T> datas = GetDatasFromJson();
            datas.Add(item);

            string jsonData = JsonConvert.SerializeObject(datas, Formatting.Indented);
            File.WriteAllText(_dataFile, jsonData);
        }

        public IEnumerable<T> GetAll()
        {
            return GetDatasFromJson();
        }

        public T GetById(int id)
        {
            List<T> datas = GetDatasFromJson();
            return datas.Find(item => (int)typeof(T).GetProperty("id")?.GetValue(item) == id);
        }

        public bool Update(T item)
        {
            List<T> datas = GetDatasFromJson();
            int index = datas.FindIndex(item => (int)typeof(T).GetProperty("id")?.GetValue(item) == (int)typeof(T).GetProperty("id")?.GetValue(item));
            if (index != -1)
            {
                datas[index] = item;
                UpdateJsonFile(datas);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            List<T> datas = GetDatasFromJson();
            T itemToRemove = datas.Find(item => (int)typeof(T).GetProperty("id")?.GetValue(item) == id);
            if (itemToRemove != null)
            {
                datas.Remove(itemToRemove);
                UpdateJsonFile(datas);
                return true;
            }
            return false;
        }

        public List<T> GetDatasFromJson()
        {
            List<T> datas = new List<T>();

            if (File.Exists(_dataFile))
            {
                string jsonData = File.ReadAllText(_dataFile);
                datas = JsonConvert.DeserializeObject<List<T>>(jsonData);
            }

            return datas;
        }

        public void UpdateJsonFile(List<T> datas)
        {
            string jsonData = JsonConvert.SerializeObject(datas, Formatting.Indented);
            File.WriteAllText(_dataFile, jsonData);
        }
    }
}