﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoraleFromThroughout : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MoraleFrom(gameObject);
    }

    public static void MoraleFrom(GameObject A) 
    {
        float screenW = Screen.height;
        
        float X= (screenW - 1080) / (1284 - 1080) * 0.15f + 0.8f;
        A.transform.localScale = new Vector3(A.transform.localScale.x*X, A.transform.localScale.x * X, A.transform.localScale.x * X);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
