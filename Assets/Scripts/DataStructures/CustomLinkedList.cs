using System;

public class CustomLinkedList<T>
{
    private Node<T> head;
    private int count;

    public CustomLinkedList()
    {
        head = null;
        count = 0;
    }

    public int Count
    {
        get { return count; }
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public void Add(T item)
    {
        Node<T> newNode = new Node<T>(item);

        if (head == null)
        {
            head = newNode;
            count++;
            return;
        }

        Node<T> current = head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
        count++;
    }
    public bool Find(T item)
    {
        Node<T> current = head;

        while (current != null)
        {
            if (current.Data.Equals(item))
            {
                return true;
            }

            current = current.Next;
        }

        return false;
    }
    public bool Remove(T item)
    {
        if (head == null)
        {
            return false;
        }

        if (head.Data.Equals(item))
        {
            head = head.Next;
            count--;
            return true;
        }

        Node<T> current = head;

        while (current.Next != null)
        {
            if (current.Next.Data.Equals(item))
            {
                current.Next = current.Next.Next;
                count--;
                return true;
            }

            current = current.Next;
        }

        return false;
    }




    public void Traverse(Action<T> action)
    {
        Node<T> current = head;

        while (current != null)
        {
            action(current.Data);
            current = current.Next;
        }
    }
}