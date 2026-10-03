using UnityEngine;
using AlgoWorks.DataStructures;

public class LinkedListTest : MonoBehaviour
{
    void Start()
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        Debug.Log("Cantidad: " + list.Count);

        list.Traverse(item => Debug.Log(item));

        Debug.Log("Existe 20: " + list.Find(20));

        list.Remove(20);

        Debug.Log("Después de eliminar 20:");

        list.Traverse(item => Debug.Log(item));
    }
}