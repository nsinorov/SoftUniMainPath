
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
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
