
namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private class ListNode
        {
            public int Value { get; set; }

            public ListNode NextNode { get; set; }

            public ListNode PrivousNode { get; set; }

            public ListNode(int value)
            {
                Value = value;
            }
        }

        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            var newHead = new ListNode(element);

            if (Count == 0)
            {
                head = newHead;
                tail = newHead;
            }
            else
            {
                newHead.NextNode = head;
                head.PrivousNode = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(int element)
        {
            var newTail = new ListNode(element);

            if (Count == 0)
            {
                head = newTail;
                tail = newTail;
            }
            else
            {
                newTail.PrivousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }
            Count++;
        }

        public int RemoveFirst()
        {
            Validate();

            var firstElement = head.Value;
            head = head.NextNode;

            if (head != null)
            {
                head.PrivousNode = null;
            }
            else
            {
                tail = null;
            }

            Count--;

            return firstElement;
        }

     

        public int RemoveLast()
        {
            Validate();

            var lastElement = tail.Value;
            tail = tail.PrivousNode;

            if (tail != null)
            {
                tail.NextNode = null;
            }
            else
            {
                head = null;
            }

            Count--;

            return lastElement;
        }

        public void ForEach(Action<int> action)
        {
            var currentNode = head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            int counter = 0;
            var currentNode = head;

            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode = currentNode.NextNode;
                counter++;
            }

            return array;
        }
        private void Validate()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
        }
    }
}
