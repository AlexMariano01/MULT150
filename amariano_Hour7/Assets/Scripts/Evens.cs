using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 22;
        while(count <= 100)
        {
            Debug.Log(count);
            count += 2;
        }
    }
}
