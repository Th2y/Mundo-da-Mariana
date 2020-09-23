using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SalvarPontuacao : MonoBehaviour
{
    public Text[] pontuacaoTexto;
    public string nomeDaCena;
    int pontos;
    private int maiorPontuacao;
    public Text[] pontosMenu;

    private void Start()
    {
        nomeDaCena = SceneManager.GetActiveScene().name;
        pontos = 0;
        maiorPontuacao = 0;
        if (nomeDaCena != "Menu" && nomeDaCena != "Menu_2" && nomeDaCena != "Menu_3" && nomeDaCena != "Menu_4" && nomeDaCena != "Menu_5")
        {
            pontuacaoTexto[0].text = pontos.ToString();
            pontuacaoTexto[1].text = pontos.ToString();
        }
        //PlayerPrefs.DeleteKey (nomeDaCena + "score");
        if (PlayerPrefs.HasKey(nomeDaCena + "score"))
            maiorPontuacao = PlayerPrefs.GetInt(nomeDaCena + "score");

        Pontos();
    }

    void Pontos()
    {
        if (nomeDaCena == "Menu")
        {
            pontosMenu[0].text = PlayerPrefs.GetInt("Fase_01score").ToString();
            pontosMenu[1].text = PlayerPrefs.GetInt("Fase_02score").ToString();
            pontosMenu[2].text = PlayerPrefs.GetInt("Fase_03score").ToString();
            pontosMenu[3].text = PlayerPrefs.GetInt("Fase_04score").ToString();
            pontosMenu[4].text = PlayerPrefs.GetInt("Fase_05score").ToString();
        }

        else if (nomeDaCena == "Menu_2")
        {
            pontosMenu[0].text = PlayerPrefs.GetInt("Fase_01_2score").ToString();
            pontosMenu[1].text = PlayerPrefs.GetInt("Fase_02_2score").ToString();
            pontosMenu[2].text = PlayerPrefs.GetInt("Fase_03_2score").ToString();
            pontosMenu[3].text = PlayerPrefs.GetInt("Fase_04_2score").ToString();
            pontosMenu[4].text = PlayerPrefs.GetInt("Fase_05_2score").ToString();
        }

        else if (nomeDaCena == "Menu_3")
        {
            pontosMenu[0].text = PlayerPrefs.GetInt("Fase_01_3score").ToString();
            pontosMenu[1].text = PlayerPrefs.GetInt("Fase_02_3score").ToString();
            pontosMenu[2].text = PlayerPrefs.GetInt("Fase_03_3score").ToString();
            pontosMenu[3].text = PlayerPrefs.GetInt("Fase_04_3score").ToString();
            pontosMenu[4].text = PlayerPrefs.GetInt("Fase_05_3score").ToString();
        }

        else if (nomeDaCena == "Menu_4")
        {
            pontosMenu[0].text = PlayerPrefs.GetInt("Fase_01_4score").ToString();
            pontosMenu[1].text = PlayerPrefs.GetInt("Fase_02_4score").ToString();
            pontosMenu[2].text = PlayerPrefs.GetInt("Fase_03_4score").ToString();
            pontosMenu[3].text = PlayerPrefs.GetInt("Fase_04_4score").ToString();
            pontosMenu[4].text = PlayerPrefs.GetInt("Fase_05_4score").ToString();
        }

        else if (nomeDaCena == "Menu_5")
        {
            pontosMenu[0].text = PlayerPrefs.GetInt("Fase_01_5score").ToString();
            pontosMenu[1].text = PlayerPrefs.GetInt("Fase_02_5score").ToString();
            pontosMenu[2].text = PlayerPrefs.GetInt("Fase_03_5score").ToString();
            pontosMenu[3].text = PlayerPrefs.GetInt("Fase_04_5score").ToString();
            pontosMenu[4].text = PlayerPrefs.GetInt("Fase_05_5score").ToString();
        }
    }

    private void Update()
    {
        pontos = ((int)(Gata.contarColetaveis * 10 + ChecarCompletou.contadorAcertos * 1000 + Mensagem.vidasRestantes * 100));

        if (nomeDaCena != "Menu" && nomeDaCena != "Menu_2" && nomeDaCena != "Menu_3" && nomeDaCena != "Menu_4" && nomeDaCena != "Menu_5")
        {
            pontuacaoTexto[0].text = "Pontuação: " + pontos.ToString() + " pontos";
            pontuacaoTexto[1].text = "Pontuação: " + pontos.ToString() + " pontos";
        }

        ChecarScore();
    }

    void ChecarScore()
    {
        if (pontos > maiorPontuacao)
        {
            maiorPontuacao = pontos;
            PlayerPrefs.SetInt(nomeDaCena + "score", maiorPontuacao);
        }
    }
}
