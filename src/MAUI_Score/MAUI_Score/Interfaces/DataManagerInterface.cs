using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Interfaces
{
    internal interface DataManagerInterface<T>
    {
        void Add(T item);
        bool Update(T item);
        bool Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
