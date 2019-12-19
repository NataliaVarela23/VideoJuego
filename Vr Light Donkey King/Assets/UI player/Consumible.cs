using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumible : MonoBehaviour
{
    public GameObject pej;
    public Vector3 distancia3d;
    public float distancia;
    public float tolerancia;

    public int tipo;//1;rice 2; intentos
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pej = GameObject.FindGameObjectWithTag("Wukong");
        if (pej != null)
        {
            distancia3d = transform.position - pej.transform.position;
            distancia = distancia3d.magnitude;

            if (distancia < tolerancia )
            {
                if (tipo == 1 & Animation1.vidas < 5)
                {
                    Destroy(this.gameObject);
                    PlayerPrefs.SetInt("arrzoi", PlayerPrefs.GetInt("arrzoi") + 1);
                    Animation1.vidas += 1;
                }
                if (tipo == 2)
                {
                    PlayerPrefs.SetInt("intent", PlayerPrefs.GetInt("intent") + 1);
                    Destroy(this.gameObject);
                    Animation1.intentos += 1;
                }
            }
        }
    }
}
