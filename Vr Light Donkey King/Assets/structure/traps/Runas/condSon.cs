using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condSon : MonoBehaviour
{
    public bool touch;
    public GameObject Pisable;
    public GameObject noPisable;

    // Start is called before the first frame update
    void Start()
    {
        Pisable.SetActive(false);
        noPisable.SetActive(false);
    }
    public void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            touch = false;
            Gmanager.pisada = 0;
            //condPar.touchaStatic = touch;
            //condPar Parent = GetComponentInParent<condPar>();
            //Parent.toucha = touch;
        }
    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            touch = true;
            Gmanager.pisada = 1;
            //condPar Parent = GetComponentInParent<condPar>();
            //Parent.toucha = touch;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Gmanager.pisada == 1)
        {
            gameObject.tag = "ExcludeTeleport";
            Pisable.SetActive(false);
            noPisable.SetActive(true);
            if (touch)
            {
                gameObject.tag = "Untagged";
                Pisable.SetActive(true);
                noPisable.SetActive(false);
            }
        }
        
        if (Gmanager.pisada == 0 | Gmanager.Ppisada == 1)
        {
            gameObject.tag = "Untagged";
            Pisable.SetActive(true);
            noPisable.SetActive(false);
        }
    }
}
