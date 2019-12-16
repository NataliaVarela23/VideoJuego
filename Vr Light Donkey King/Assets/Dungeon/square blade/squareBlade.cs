using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squareBlade : MonoBehaviour
{
    public float speed;
    public float timer1;
    public Vector3 direc;
    public bool atc = true;
    public Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "box")
        {
            if (other.gameObject.GetComponent<boxScript>().dir != direc)
            {
                atc = false;
                StartCoroutine(ReAtck());
                direc = other.gameObject.GetComponent<boxScript>().dir;
            }
        }
    }
    IEnumerator ReAtck()
    {
        yield return new WaitForSeconds(timer1);
        {
            atc = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (atc)
        {
            anime.SetBool("atck", true);// Modifica el bool
            transform.Translate(direc * Time.deltaTime * speed);
        }
        else
            anime.SetBool("atck", false);
    }
}
