using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChecarCompletou : MonoBehaviour
{
    float cronometro;
    public Mensagem mensagem;

    public Text TextAcertos;
    public static int contadorAcertos;

    void Start()
    {
        cronometro = 0;

        TextAcertos.text = contadorAcertos.ToString();
    }

    void Update()
    {
        cronometro += Time.deltaTime;
        if(cronometro >= 0.2f)
        {
            cronometro = 0;

            contadorAcertos = mensagem.contar;

            TextAcertos.text = contadorAcertos.ToString();
        }
    }
}
