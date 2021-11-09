using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i < array.Length; i--)
        {
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
