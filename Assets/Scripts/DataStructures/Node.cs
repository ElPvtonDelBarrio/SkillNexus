namespace AlgoWorks.DataStructures
{
    public class Node<T> // T: Generic type parameter that allows the Node class to store data of any type.
    {
        // Atributes
        private T data;
        private Node<T> next;

        //Methods

        // 1. Constructor to initialize the Node with data and set the next node to null.
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
        // 2. Property to get or set the data stored in the Node.
        public T Data
        {
            get => data;
            set => data = value;
        }
        // 3. Property to get or set the reference to the next Node in the linked list.
        public Node<T> Next
        {
            get => next;
            set => next = value;
        }
    }
}