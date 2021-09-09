using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWhenLoad : MonoBehaviour
{

    // Use this for initialization
    void Awake()
    {
        GameObject A = GameObject.FindGameObjectWithTag("music");
        Destroy(A);

    }
}
