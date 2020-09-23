using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mensagem : MonoBehaviour
{
    public GameObject[] painelBox;
    public GameObject[] respostas;
    public GameObject[] pergunta01;
    public GameObject[] pergunta03;
    public GameObject[] pergunta04;
    public int contar = 0;
    private int numeroDeVidas;
    public static int vidasRestantes;
    public GameObject[] vidas;
    //public ChecarCompletou checarCompletou;

    void Start()
    {
        if (EscolhaASuaSerie.cena == 1)
            numeroDeVidas = 6;
        else if (EscolhaASuaSerie.cena == 2)
            numeroDeVidas = 5;
        else if (EscolhaASuaSerie.cena == 3)
            numeroDeVidas = 4;
        else if (EscolhaASuaSerie.cena == 4 || EscolhaASuaSerie.cena == 5)
            numeroDeVidas = 3;

        vidasRestantes = numeroDeVidas;
    }

    void Update()
    {
        vidasRestantes = numeroDeVidas;

        if (EscolhaASuaSerie.cena == 1)
        {
            if (numeroDeVidas >= 6)
            {
                numeroDeVidas = 6;
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(true);
                vidas[3].SetActive(true);
                vidas[4].SetActive(true);
                vidas[5].SetActive(true);
            }
            else if (numeroDeVidas == 5)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(true);
                vidas[3].SetActive(true);
                vidas[4].SetActive(true);
                vidas[5].SetActive(false);
            }
            else if (numeroDeVidas == 4)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(true);
                vidas[3].SetActive(true);
                vidas[4].SetActive(false);
            }

            else if (numeroDeVidas == 3)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(true);
                vidas[3].SetActive(false);
            }

            else if (numeroDeVidas == 2)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(false);
            }

            else if (numeroDeVidas == 1)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(false);
            }

            else if(numeroDeVidas == 0)
            {
                Temporizador.acabou = 0f;
                vidas[0].SetActive(false);
            }
        }

        if (EscolhaASuaSerie.cena == 2)
        {
            if (numeroDeVidas >= 5)
            {
                numeroDeVidas = 5;
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(true);
                vidas[3].SetActive(true);
                vidas[4].SetActive(true);
            }
            else if (numeroDeVidas == 4)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(true);
                vidas[3].SetActive(true);
                vidas[4].SetActive(false);
            }
            else if (numeroDeVidas == 3)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(true);
                vidas[3].SetActive(false);
            }

            else if (numeroDeVidas == 2)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(false);
            }

            else if (numeroDeVidas == 1)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(false);
            }

            else
            {
                Temporizador.acabou = 0f;
                vidas[0].SetActive(false);
            }
        }

        if (EscolhaASuaSerie.cena == 3)
        {
            if (numeroDeVidas >= 4)
            {
                numeroDeVidas = 4;
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(true);
                vidas[3].SetActive(true);
            }
            else if (numeroDeVidas == 3)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(true);
                vidas[3].SetActive(false);
            }
            else if (numeroDeVidas == 2)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(false);
            }

            else if (numeroDeVidas == 1)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(false);
            }

            else
            {
                Temporizador.acabou = 0f;
                vidas[0].SetActive(false);
            }
        }

        if (EscolhaASuaSerie.cena == 4 || EscolhaASuaSerie.cena == 5)
        {
            if (numeroDeVidas >= 3)
            {
                numeroDeVidas = 3;
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(true);
            }
            else if (numeroDeVidas == 2)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(false);
            }
            else if (numeroDeVidas == 1)
            {
                vidas[0].SetActive(true);
                vidas[1].SetActive(false);
            }

            else
            {
                Temporizador.acabou = 0f;
                vidas[0].SetActive(false);
            }
        }
    }

    public void CarregarOpcoes(string _opcoes)
    {
        switch (_opcoes)
        {
            case "AVANCAR_01":
                painelBox[0].SetActive(false);//chat
                painelBox[1].SetActive(true);//rato01
                break;
            case "AVANCAR_02":
                painelBox[1].SetActive(false);
                painelBox[2].SetActive(true);//gata01
                break;
            case "AVANCAR_03":
                painelBox[2].SetActive(false);
                painelBox[3].SetActive(true);//rato02
                break;
            case "AVANCAR_04":
                painelBox[3].SetActive(false);
                painelBox[4].SetActive(true);//gata02
                break;
            case "AVANCAR_05":
                painelBox[4].SetActive(false);
                painelBox[5].SetActive(true);//rato03
                break;
            case "AVANCAR_06":
                painelBox[5].SetActive(false);
                painelBox[6].SetActive(true);//gata03
                break;
            case "AVANCAR_07":
                painelBox[6].SetActive(false);
                painelBox[7].SetActive(true);//rato04
                break;
            case "AVANCAR_08":
                painelBox[7].SetActive(false);
                painelBox[8].SetActive(true);//gata04
                break;
            case "RESP_CERTA":
                painelBox[8].SetActive(false);
                contar++;
                Destroy(GameObject.FindGameObjectWithTag("queijo"));
                respostas[0].SetActive(true);
                break;
            case "RESP_ERRADA":
                painelBox[8].SetActive(false);
                respostas[1].SetActive(true);
                numeroDeVidas -= 1;
                break;
            case "CONTINUAR_ACERTO":
                respostas[0].SetActive(false);
                PausarParaPerguntar.emPergunta = false;
                break;
            case "CONTINUAR_ERRO":
                respostas[1].SetActive(false);
                painelBox[8].SetActive(true);
                break;
        }
    }

    public void Pergunta01(string _pergunta)
    {
        switch (_pergunta)
        {
            case "RESP_CERTA": //apertou na resposta certa
                pergunta01[0].SetActive(false);
                contar++;
                pergunta01[1].SetActive(true);
                break;
            case "RESP_ERRADA": //apertou na resposta errada
                pergunta01[0].SetActive(false);
                pergunta01[2].SetActive(true);
                numeroDeVidas -= 1;
                break;
            case "CONTINUAR_ACERTO": //apertou continuar apos acertar
                pergunta01[1].SetActive(false);
                PausarParaPerguntar.emPergunta = false;
                break;
            case "CONTINUAR_ERRO": //apertou continuar apos errar
                pergunta01[2].SetActive(false);
                pergunta01[0].SetActive(true);
                break;
        }
    }

    public void Pergunta03(string _pergunta)
    {
        switch (_pergunta)
        {
            case "RESP_CERTA": //apertou na resposta certa
                pergunta03[0].SetActive(false);
                contar++;
                pergunta03[1].SetActive(true);
                break;
            case "RESP_ERRADA": //apertou na resposta errada
                pergunta03[0].SetActive(false);
                pergunta03[2].SetActive(true);
                numeroDeVidas -= 1;
                break;
            case "CONTINUAR_ACERTO": //apertou continuar apos acertar
                pergunta03[1].SetActive(false);
                PausarParaPerguntar.emPergunta = false;
                break;
            case "CONTINUAR_ERRO": //apertou continuar apos errar
                pergunta03[2].SetActive(false);
                pergunta03[0].SetActive(true);
                break;
        }
    }

    public void Pergunta04(string _pergunta)
    {
        switch (_pergunta)
        {
            case "RESP_CERTA": //apertou na resposta certa
                pergunta04[0].SetActive(false);
                contar++;
                pergunta04[1].SetActive(true);
                break;
            case "RESP_ERRADA": //apertou na resposta errada
                pergunta04[0].SetActive(false);
                pergunta04[2].SetActive(true);
                numeroDeVidas -= 1;
                break;
            case "CONTINUAR_ACERTO": //apertou continuar apos acertar
                pergunta04[1].SetActive(false);
                PausarParaPerguntar.emPergunta = false;
                break;
            case "CONTINUAR_ERRO": //apertou continuar apos errar
                pergunta04[2].SetActive(false);
                pergunta04[0].SetActive(true);
                break;
        }
    }
}
