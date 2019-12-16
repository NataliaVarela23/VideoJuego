using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation1 : MonoBehaviour
{
    public Animator anime;
    public static int key;
    public int ky;
    public int vd;
    public static int jumpKey = 0;
    public static int intentos = 3;
    public static int vidas = 3;
    public static Vector3 Respaun;
    public Vector3 ResMon;
    public GameObject pj;
    public float timer1 = 5;
    public GameObject camSun;
    public GameObject dungeon;

    public static bool inmortals;
    public float imortalTimer = 3;
    public bool inmorMonitor;
    public static int Goblins;

    // Start is called before the first frame update
   
    public void Respauwn()
    {
        pj.transform.localPosition = Respaun;
    }

    public void Tp(Vector3 land)
    {
        pj.transform.localPosition = land;
    }
    public void Start()
    {
        StartCoroutine(Light());
    }
    IEnumerator Light()
    {
        yield return new WaitForSeconds(timer1);
        {
            camSun.SetActive(true);
            dungeon.SetActive(false);
            print("don't forget to enable this");
        }
    }
    public void Inmortal()
    {
        inmortals = true;
        Invoke("mortale", imortalTimer);

        if(vidas < 1)
        {
            Respauwn();
            intentos--;
            vidas = 3;
        }
    }
    public void mortale()
    {
        inmortals = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vidas -= 1;
        }

        ResMon = Respaun;
        ky = key;
        vd = vidas;
        inmorMonitor = inmortals;
        //Animaciones según teclado

        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.D))
        {
            anime.SetBool("Run", true);// Modifica el bool
        }
        if (Input.GetKeyUp(KeyCode.W) | Input.GetKeyUp(KeyCode.A) | Input.GetKeyUp(KeyCode.S) | Input.GetKeyUp(KeyCode.D))
        {
            anime.SetBool("Run", false);// Modifica el bool
        }


        

    }
}
