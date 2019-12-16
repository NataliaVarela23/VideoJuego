using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpCountUI : MonoBehaviour
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
        transpaso = Animation1.jumpKey;
        textChange.text = transpaso.ToString();
    }
}
