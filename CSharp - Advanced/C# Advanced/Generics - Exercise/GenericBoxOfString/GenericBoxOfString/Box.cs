
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T> where T : IComparable<T>
    {

        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Swap(int firstItem, int secondItem)
        {
            T temp = items[firstItem];
            items[firstItem] = items[secondItem];
            items[secondItem] = temp;
        }

        public int Count(T itemsToCompare)
        {
            int count = 0;

            foreach (var item in items)
            {
                if (item.CompareTo(itemsToCompare) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();

            foreach (T item in items)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
