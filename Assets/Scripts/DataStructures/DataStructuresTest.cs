using System;
using UnityEngine;

public class DataStructuresTest : MonoBehaviour
{
    void Start()
    {
        TestEmptyList();
        TestAddOneElement();
        TestAddMultipleElements();
        TestFindExistingElement();
        TestFindNonExistingElement();
        TestRemoveFirstElement();
        TestRemoveMiddleElement();
        TestRemoveLastElement();
        TestRemoveOnlyElement();
        TestRemoveNonExistingElement();

        Demo();
    }

    // Test 1: Empty list
    void TestEmptyList()
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        Debug.Assert(list.Count == 0);
        Debug.Assert(list.IsEmpty());
    }

    // Test 2: Add one element
    void TestAddOneElement()
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        list.Add(10);

        Debug.Assert(list.Count == 1);
        Debug.Assert(!list.IsEmpty());
    }

    // Test 3: Add multiple elements
    void TestAddMultipleElements()
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        Debug.Assert(list.Count == 3);
    }

    // Test 4: Find existing element
    void TestFindExistingElement()
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        Debug.Assert(list.Find(20));
    }

    // Test 5: Find non-existing element
    void TestFindNonExistingElement()
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        Debug.Assert(!list.Find(50));
    }

    // Test 6: Remove first element
    void TestRemoveFirstElement()
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        Debug.Assert(list.Remove(10));
        Debug.Assert(list.Count == 2);
    }

    // Test 7: Remove middle element
    void TestRemoveMiddleElement()
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        Debug.Assert(list.Remove(20));
        Debug.Assert(list.Count == 2);
        Debug.Assert(!list.Find(20));
    }

    // Test 8: Remove last element
    void TestRemoveLastElement()
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        Debug.Assert(list.Remove(30));
        Debug.Assert(list.Count == 2);
    }

    // Test 9: Remove only element
    void TestRemoveOnlyElement()
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        list.Add(10);

        Debug.Assert(list.Remove(10));
        Debug.Assert(list.Count == 0);
        Debug.Assert(list.IsEmpty());
    }

    // Test 10: Remove non-existing element
    void TestRemoveNonExistingElement()
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        Debug.Assert(!list.Remove(50));
        Debug.Assert(list.Count == 3);
    }

    // Main demonstration
    void Demo()
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        Debug.Log("CustomLinkedList<int>");
        Debug.Log("");

        Debug.Log("Add(10)");
        list.Add(10);

        Debug.Log("Add(20)");
        list.Add(20);

        Debug.Log("Add(30)");
        list.Add(30);

        Debug.Log("");
        Debug.Log("Resultado:");
        Debug.Log("");
        Debug.Log("10 → 20 → 30 → null");

        Debug.Log("");
        Debug.Log("Count = " + list.Count);
        Debug.Log("IsEmpty = " + list.IsEmpty());

        Debug.Log("");
        Debug.Log("Find(20)");

        if (list.Find(20))
        {
            Debug.Log("→ encontrado");
        }

        Debug.Log("");
        Debug.Log("Remove(20)");

        list.Remove(20);

        Debug.Log("");
        Debug.Log("10 → 30 → null");

        Debug.Log("Count = " + list.Count);
    }
}
