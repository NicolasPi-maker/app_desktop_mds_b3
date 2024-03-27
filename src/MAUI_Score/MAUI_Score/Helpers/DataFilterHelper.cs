using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Helpers
{
    public static class DataFilterHelper
    {
        public static IEnumerable<T> FilterByCondition<T>(IEnumerable<T> data, Func<T, bool> condition)
        {
            return data.Where(condition);
        }

        public static IEnumerable<T> FilterByProperty<T, TKey>(IEnumerable<T> data, Func<T, TKey> selector, TKey value)
        {
            return data.Where(item => selector(item).Equals(value));
        }

        public static IEnumerable<T> FilterBySearch<T>(IEnumerable<T> data, Func<T, string> searchProperty, string searchValue)
        {
            return data.Where(item => searchProperty(item).Contains(searchValue));
        }
    }
}
