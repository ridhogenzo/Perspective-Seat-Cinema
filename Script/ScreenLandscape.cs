using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenLandscape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            Screen.orientation = ScreenOrientation.Landscape; // or Portrait or something another
        }
    }

    
}
