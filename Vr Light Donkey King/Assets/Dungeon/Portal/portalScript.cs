using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class portalScript : MonoBehaviour
{
    public int acces;
    public Animator anim;
    public float timer1;
    public Vector3 landa;
    public GameObject pej;
    public GameObject camSun;
    public GameObject camDung;
    public GameObject Mountain;
    public GameObject dungeon;

    public GameObject trap1;
    public GameObject trap2;

    public Text textChange;
    public int transpaso;
    public GameObject camara;
    public GameObject UI;

    public bool Interior;
    public bool seguro;

    void Start()
    {

    }

    void Update()
    {
        textChange.text = transpaso.ToString();

        camara = GameObject.FindGameObjectWithTag("MainCamera");

        if (camara != null & Interior == false)
            UI.transform.LookAt(camara.transform);
    }
    public void OnTriggerEnter(Collider other)
    {
        if(seguro == false)
        {
            if (Animation1.key >= acces & Interior == false)
            {
                pej = GameObject.FindGameObjectWithTag("Wukong");
                anim.SetBool("Open", true);
                StartCoroutine(Move());
                Animation1.key -= acces;
                seguro = true;
            }
            if (Interior)
            {
                pej = GameObject.FindGameObjectWithTag("Wukong");
                anim.SetBool("Open", true);
                StartCoroutine(Move());
                seguro = true;
            }
        }

    }
    IEnumerator Move()
    {
        yield return new WaitForSeconds(timer1);
        {
            if (Interior == false)
            {
                pej.GetComponent<Animation1>().Tp(landa);
                camSun.SetActive(false);
                Mountain.SetActive(false);
                dungeon.SetActive(true);
                trap1.GetComponent<squareBlade>().atc = true;
                trap2.GetComponent<squareBlade>().atc = true;
            }
            if (Interior)
            {
                pej.GetComponent<Animation1>().Tp(landa);
                camSun.SetActive(true);
                Mountain.SetActive(true);
                dungeon.SetActive(false);
            }

        }
    }
}
