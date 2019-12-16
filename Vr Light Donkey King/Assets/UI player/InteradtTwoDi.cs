using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteradtTwoDi : MonoBehaviour
{
    public GameObject camara;
    public GameObject pej;
    public GameObject UI;

    public Vector3 distancia3d;
    public float distancia;
    public float tolerancia;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pej = GameObject.FindGameObjectWithTag("Wukong");
        camara = GameObject.FindGameObjectWithTag("MainCamera");

        if(camara != null)
        transform.LookAt(camara.transform);

        if (pej != null)
        {
            distancia3d = transform.position - pej.transform.position;
            distancia = distancia3d.magnitude;

                if (distancia < tolerancia)
                {
                    if (UI != null)
                        UI.SetActive(false);
                }
                else
                {
                    if (UI != null)
                        UI.SetActive(true);
                }

        }

    }
}
