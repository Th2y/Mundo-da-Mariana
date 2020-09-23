using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Avisos : MonoBehaviour
{
    public static Text aviso01;
    public Text aviso1;
    [Range(0.1f, 10.0f)] public float distancia = 3;
    private GameObject rato;

    private float tempoSumir = 5f;
    public float tempoDestruirQueijo = 25f;

    void Start()
    {
        aviso01 = aviso1;
        aviso1.enabled = false;
        rato = GameObject.FindWithTag("rato");
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, rato.transform.position) < distancia)
        {
            tempoSumir -= Time.deltaTime;
            if (tempoSumir > 0)
                aviso1.enabled = true;
            else
            {
                aviso1.enabled = false;
                tempoDestruirQueijo -= Time.deltaTime;

                if (tempoDestruirQueijo <= 0)
                    Destroy(GameObject.FindGameObjectWithTag("queijo"));
            }
        }
    }
}
