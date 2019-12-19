using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public float rotTas;
    Collider m_Collider;
    public Vector3 dits;
    public GameObject Player;
    public float tolerancia;
    public float tol;
    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider>();

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt("cn", PlayerPrefs.GetInt("cn") + 1);
            Destroy(gameObject);
            Animation1.key += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Wukong");
        transform.Rotate(new Vector3(0f, 0f, rotTas));
        if(Player != null)
        dits = transform.position - Player.transform.position;

        tol = dits.magnitude;

        if(tol < tolerancia)
        {
            m_Collider.enabled = true;
        }
        else
        {
            m_Collider.enabled = false;
        }
    }
}
