using labor11;
namespace labor11
{
    public class DoublyLinkedList<T>
    {
        DoublyNode<T> head;
        DoublyNode<T> tail;
        public void Add(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }
        public void Delete(T data)
        {
            DoublyNode<T> node = head;
            if(count == 0)
            {
                throw new ArgumentException("нельзя удалить из нулевого списка");
            }
            while(node != null)
            {
                if (node.Data.Equals(data))
                {
                    break;
                }
                node=node.Next;
            }
            if (node != null)
            {
                if (node.Next != null)
                {
                    node.Next.Previous = node.Previous;
                }
                else
                {
                    tail = node.Previous;
                }

                if (node.Previous != null)
                {
                    node.Previous.Next = node.Next;
                }
                else
                {
                    head = node.Next;
                }
                count--;
            }
            else
            {
                Console.WriteLine("такого элемента нет");
            }
        }
        public T GetFirst
        {
            get { return head.Data; }
        }
        public T GetLast
        {
            get { return tail.Data; }
        }
        public string total()
        {
            DoublyNode<T> node = head;
            string str = "";
            for(int i=0; i<count; i++)
            {
                str += node.Data + " ";
                node = node.Next;
            }
            return str;
        }
        int count;
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
    }
    public class DoublyNode<T>
    {
        public DoublyNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
    }
}
