using UnityEngine;
using AlgoWorks.DataStructures;

public class NodeTest : MonoBehaviour
{
    void Start()
    {
        Node<int> node1 = new Node<int>(10);
        Node<int> node2 = new Node<int>(20);
        Node<int> node3 = new Node<int>(30);

        node1.Next = node2;
        node2.Next = node3;

        Debug.Log(node1.Data);
        Debug.Log(node1.Next.Data);
        Debug.Log(node1.Next.Next.Data);
    }
}