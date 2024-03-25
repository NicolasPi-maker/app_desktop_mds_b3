using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Datas
{
    public class DataManager<T> : Interfaces.DataManagerInterface<T> where T : class
    {
        private static readonly List<T> _items = new List<T>();
        private static int _nextId = 1;

        private DataManager() { }

        public static DataManager<T> GetInstance()
        {
            return new DataManager<T>();
        }

        public void Add(T item)
        {
            typeof(T).GetProperty("id")?.SetValue(item, _nextId++);
            _items.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public T GetById(int id)
        {
            return _items.Find(item => (int)typeof(T).GetProperty("id")?.GetValue(item) == id);
        }

        public bool Update(T item)
        {
            int index = _items.FindIndex(existingItem => (int)typeof(T).GetProperty("id")?.GetValue(existingItem) == (int)typeof(T).GetProperty("id")?.GetValue(item));
            if (index != -1)
            {
                _items[index] = item;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            T itemToRemove = GetById(id);
            if (itemToRemove != null)
            {
                _items.Remove(itemToRemove);
                return true;
            }
            return false;
        }
    }
}
