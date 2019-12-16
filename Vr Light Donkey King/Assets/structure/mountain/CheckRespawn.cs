using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRespawn : MonoBehaviour
{
    public GameObject pej;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        pej = GameObject.FindGameObjectWithTag("Wukong");
        if (other.tag == "Player")
        {
            pej.GetComponent<Animation1>().Respauwn();
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
