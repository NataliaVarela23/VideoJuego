﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUIScript : MonoBehaviour
{
    public Text textChange;

    int transpaso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transpaso = Animation1.key;
        textChange.text = transpaso.ToString();
    }
}
