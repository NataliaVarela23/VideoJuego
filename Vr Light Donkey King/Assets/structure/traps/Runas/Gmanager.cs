using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gmanager : MonoBehaviour
{
    public static int pisada;//monitorea condicionales para determinar son transitables o no
    public static int Ppisada;//monitorea safe step para anular el no se puede pasar
    public int pis;
    public int pus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pis = pisada;
        pus = Ppisada;
    }
}
