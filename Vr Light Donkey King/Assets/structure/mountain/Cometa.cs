using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cometa : MonoBehaviour
{
    public GameObject CheckAux;

    public Vector3 offset;
    public bool activated;
    public bool IsHidden;

    // Start is called before the first frame update
    void Start()
    {
        CheckAux.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Animation1.Respaun = new Vector3(offset.x, offset.y, offset.z);
        }
        if (activated == false & IsHidden == false)
        {

            activated = true;
            CheckAux.SetActive(true);

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
