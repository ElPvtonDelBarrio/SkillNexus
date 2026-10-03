namespace AlgoWorks.DataStructures
{
    public class Node<T>
    {
        private T data;
        private Node<T> next;

        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }

        public T Data
        {
            get => data;
            set => data = value;
        }

        public Node<T> Next
        {
            get => next;
            set => next = value;
        }
    }
}