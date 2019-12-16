using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pin : MonoBehaviour
{
    public float timer0;//desfase antes de comenzar el ciclo

    public float timer1;//no tocar
    public float StayDown;
    public float timer3;//no tocar
    public float StayUp;

    public Animator anime;
    public Animator anime2;

    public float fill;
    public float fillDelta = 0.03f;
    public float radFill;
    public Image image;

    public float Timeperc;
    public bool parpadear;
    public float parpTimer = 0.1f;
    public GameObject Red;
    public GameObject Green;
    public bool pasive;

    public Vector3 distancia3d;
    public float distancia;
    public float tolerancia;
    public GameObject pej;
    public GameObject sph;
    // Start is called before the first frame update
    void Start()
    {
        anime2.Play("get bigger");
        anime.SetInteger("Fase", 1);
        Invoke("Atck", timer0);
        Invoke("Parp1", parpTimer);
        pasive = false;
    }

    // Update is called once per frame
    public void Atck()
    {

        anime.SetInteger("Fase", 2);
        Invoke("StyOf", timer1);


        

    }
    public void StyOf()
    {
        anime2.Play("GetSmaller");
        anime.SetInteger("Fase", 3);
        Invoke("Bck", StayDown);
        fill = (timer1 + StayDown) *Timeperc;

        Green.SetActive(true);
        parpadear = false;
        pasive = true;

    }
    public void Bck()
    {

        anime.SetInteger("Fase", 0);
        Invoke("StyPas", timer3);


    }
    public void StyPas()
    {
        anime2.Play("get bigger");
        anime.SetInteger("Fase", 1);
        Invoke("Atck", StayUp);


        parpadear = false;
        Green.SetActive(false);
        Red.SetActive(false);

        pasive = false;

    }

    public void Parp1()
    {
        Invoke("Parp2", parpTimer);
        if(parpadear)
        {
            Green.SetActive(false);
            Red.SetActive(true);
        }
    }
    public void Parp2()
    {
        Invoke("Parp1", parpTimer);
        if (parpadear)
        {
            Green.SetActive(true);
            Red.SetActive(false);
        }
    }

    public void Update()
    {
        pej = GameObject.FindGameObjectWithTag("Wukong");

        if (pej != null)
        {
            distancia3d = transform.position - pej.transform.position;
            distancia = distancia3d.magnitude;

            if (distancia < tolerancia)
            {
                sph.SetActive(true);
            }
            if (distancia >= tolerancia)
            {
                sph.SetActive(false);
            }
        }

        fill -= fillDelta * Time.deltaTime;
        radFill = (fill/((timer1 + StayDown) * Timeperc));
        image.fillAmount = radFill;

        if(fill < 0 & pasive == true)
        {
            parpadear = true;
        }
    }
}
