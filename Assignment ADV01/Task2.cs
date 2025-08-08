using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV01
{
    public class MultiBox<T>
    {
        private List<T> items = new List<T>();

        public void InsertItem(T item)
        {
            items.Add(item);
        }

        public List<T> GetAllItems()
        {
            return new List<T>(items);
        }

        public int Count()
        {
            return items.Count;
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }

}
