using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    public Text displayContagem;
    //public static float contar;
    public float contagem = 240f;
    public static float acabou;
    private int minuto, minutos;

    public GameObject painelOver;
    public static bool JogoEmPausa = false;
    public static bool musica = false;

    public GameObject peixe1;
    public GameObject peixe2;
    public GameObject peixe3;
    public GameObject peixe4;
    public GameObject peixe5;
    public GameObject peixe6;

    void Start()
    {
        //contar = contagem;
        acabou = contagem;

        peixe1.SetActive(false);
        peixe2.SetActive(false);
        peixe3.SetActive(false);
        peixe4.SetActive(false);
        peixe5.SetActive(false);
        peixe6.SetActive(false);
    }

    void Update()
    {
        if(acabou == 0)
        {
            //GerenciadorDeMusica.TrocarMusica(musicaFase.PERDEU);
            contagem = 0;
            JogoEmPausa = true;
            Time.timeScale = 0f;
            painelOver.SetActive(true);
            musica = true;
        }

        if (contagem >= 0)
        {
            contagem -= Time.deltaTime;
            //contar = contagem;

            if (contagem >= 60)
            {
                    minuto = ((int)contagem / 60);
                    displayContagem.text = minuto.ToString() + " min";
            }
            else
                displayContagem.text = contagem.ToString("f0") + " segundos";
        }

        else
        {
            JogoEmPausa = true;
            Time.timeScale = 0f;
            painelOver.SetActive(true);
            musica = true;

            if (EscolhaASuaSerie.cena == 1)
            {
                if (Mensagem.vidasRestantes == 6)
                {
                    peixe2.SetActive(true);
                    peixe4.SetActive(true);
                    peixe6.SetActive(true);
                }
                else if (Mensagem.vidasRestantes == 5)
                {
                    peixe2.SetActive(true);
                    peixe4.SetActive(true);
                    peixe5.SetActive(true);
                }
                else if (Mensagem.vidasRestantes == 4)
                {
                    peixe2.SetActive(true);
                    peixe4.SetActive(true);
                }
                else if (Mensagem.vidasRestantes == 3)
                {
                    peixe2.SetActive(true);
                    peixe3.SetActive(true);
                }
                else if (Mensagem.vidasRestantes == 2)
                    peixe2.SetActive(true);
                else if (Mensagem.vidasRestantes == 1)
                    peixe1.SetActive(true);
            }

            else if (EscolhaASuaSerie.cena == 2)
            {
                if (Mensagem.vidasRestantes == 5)
                {
                    peixe2.SetActive(true);
                    peixe4.SetActive(true);
                    peixe6.SetActive(true);
                }
                else if (Mensagem.vidasRestantes == 4)
                {
                    peixe2.SetActive(true);
                    peixe4.SetActive(true);
                }
                else if (Mensagem.vidasRestantes == 3)
                {
                    peixe2.SetActive(true);
                    peixe3.SetActive(true);
                }
                else if (Mensagem.vidasRestantes == 2)
                    peixe2.SetActive(true);
                else if (Mensagem.vidasRestantes == 1)
                    peixe1.SetActive(true);
            }

            else if (EscolhaASuaSerie.cena == 3)
            {
                if (Mensagem.vidasRestantes == 4)
                {
                    peixe2.SetActive(true);
                    peixe4.SetActive(true);
                    peixe6.SetActive(true);
                }
                else if (Mensagem.vidasRestantes == 3)
                {
                    peixe2.SetActive(true);
                    peixe4.SetActive(true);
                }
                else if (Mensagem.vidasRestantes == 2)
                    peixe2.SetActive(true);
                else if (Mensagem.vidasRestantes == 1)
                    peixe1.SetActive(true);
            }

            else if (EscolhaASuaSerie.cena == 4 || EscolhaASuaSerie.cena == 5)
            {
                if (Mensagem.vidasRestantes == 3)
                {
                    peixe2.SetActive(true);
                    peixe4.SetActive(true);
                    peixe6.SetActive(true);
                }
                else if (Mensagem.vidasRestantes == 2)
                {
                    peixe2.SetActive(true);
                    peixe4.SetActive(true);
                }
                else if (Mensagem.vidasRestantes == 1)
                    peixe2.SetActive(true);
            }
        }
    }
}
