using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{

    // Use this for initialization
    void Awake()
    {
        GameObject A = GameObject.FindGameObjectWithTag("musica");
        Destroy(A);

    }
}