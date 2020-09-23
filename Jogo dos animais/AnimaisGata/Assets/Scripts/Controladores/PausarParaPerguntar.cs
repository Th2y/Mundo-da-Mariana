using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarParaPerguntar : MonoBehaviour
{
    public GameObject scriptGata;
    public GameObject scriptTempo;
    public static bool emPergunta;

    void Start()
    {
        emPergunta = false;
    }

    void Update()
    {
        if (emPergunta)
            DesativarScripts();

        if (!emPergunta)
            AtivarScripts();
    }

    public void AtivarScripts()
    {
        scriptGata.GetComponent<Gata>().enabled = true;
        scriptTempo.GetComponent<Temporizador>().enabled = true;
    }

    void DesativarScripts()
    {
        scriptGata.GetComponent<Gata>().enabled = false;
        scriptTempo.GetComponent<Temporizador>().enabled = false;
    }
}
