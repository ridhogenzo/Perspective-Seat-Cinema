﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPortrait : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            Screen.orientation = ScreenOrientation.Portrait; // or Portrait or something another
        }
    }
}
