using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    private Queue<string> oraciones;//asignar script a objeto manager

    public Text Nombre;
    public Text cuerpo;
    public Animator cuadro;



    // Start is called before the first frame update
    void Start()
    {
        oraciones = new Queue<string>();
    }


    public void StartDialogue(Dialogos dialogo)
    {
        cuadro.SetBool("IsOpen",true);
        Nombre.text = dialogo.Name ;


        oraciones.Clear();
        foreach (string sentence in dialogo.oracion)
        {
            oraciones.Enqueue(sentence);
        }

        NextSentence();

    }

    public void NextSentence()
    {


        if (oraciones.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = oraciones.Dequeue();
        //cuerpo.text = sentence;

        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence (string sentence)
    {
        cuerpo.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            cuerpo.text += letter;
            yield return null;//espera un frame y permite funcionar a corrutina
        }
    }
    public void EndDialogue()
    {
        cuadro.SetBool("IsOpen", false);
        FindObjectOfType<endGame>().EndGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            NextSentence();
        }
    }
}
