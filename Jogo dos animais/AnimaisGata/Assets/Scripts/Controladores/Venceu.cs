using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venceu : MonoBehaviour
{
    GerenciadorDeMusica GerenciadorDeMusica;
    public GameObject painelOver;
    public static bool conseguiu = false;
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
        if (Carregamento.novoJogo == true)
            JogoEmPausa = false;

        peixe1.SetActive(false);
        peixe2.SetActive(false);
        peixe3.SetActive(false);
        peixe4.SetActive(false);
        peixe5.SetActive(false);
        peixe6.SetActive(false);
    }

    void Update()
    {
        if (JogoEmPausa == true)
            Conseguiu();
    }

    public void Conseguiu()
    {
        Time.timeScale = 0f;
        painelOver.SetActive(true);

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
            else
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
            else
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
            else
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
            else
                peixe2.SetActive(true);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            JogoEmPausa = true;
            musica = true;
        }
    }
}
