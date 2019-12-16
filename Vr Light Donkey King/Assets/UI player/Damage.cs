using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject pej;

    public float fuerza = 1.0f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" )
        {
            if (Animation1.inmortals == false)
            {
                Animation1.vidas -= 1;
                pej = GameObject.FindGameObjectWithTag("Wukong");
                if (pej != null)
                {
                    pej.GetComponent<Animation1>().Inmortal();
                    print("habilitar para versiones de pc y android");
                    //rb = pej.GetComponent<Rigidbody>();
                    //rb.AddForce((transform.position - pej.transform.position) * fuerza);
                }
                    
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
