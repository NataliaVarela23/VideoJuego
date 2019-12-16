using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass : MonoBehaviour
{
    public float timer1;
    public float rang;
    public Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        timer1 = Random.Range(0,rang);
        StartCoroutine(Starta());
    }
    IEnumerator Starta()
    {
        yield return new WaitForSeconds(timer1);
        {
            anime.SetBool("Start", true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            anime.SetBool("touch", true);
        }
    }
    public void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            anime.SetBool("touch", false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
