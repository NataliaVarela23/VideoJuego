using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalCircular : MonoBehaviour
{
    public int acces;
    public GameObject pej;
    public Animator anim;
    public bool metodoCoin;
    public GameObject golden;
    public GameObject light;
    public bool Open;

    private void Start()
    {
        if (metodoCoin)
        {
            golden.SetActive(true);
            light.SetActive(false);
        }
        if (metodoCoin == false)
        {
            golden.SetActive(false);
            light.SetActive(true);
        }

    }

    public void OnTriggerEnter(Collider other)
    {

        if (Animation1.key >= acces)
        {
            pej = GameObject.FindGameObjectWithTag("Wukong");
            anim.SetBool("Open", true);
            Animation1.key -= acces;
            Open = true;
        }
    }

    public void OpenRemote()
    {
        anim.SetBool("Open", true);
        Open = true;
    }


}
