using System;
using UnityEngine;

public class ForLoopExample : MonoBehaviour
{
    private int[] itemsToDrop = {4, 7, 1, 8, 9};

    void Start()
    {
        for (int i=0; i<itemsToDrop.Length; i++)
        {
            Debug.Log("The chest contains item: " + itemsToDrop[i].ToString());
        }
    }
}
