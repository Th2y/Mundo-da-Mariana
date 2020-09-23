using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Video : MonoBehaviour
{
    [SerializeField]
    private GameObject image;

    private void Start()
    {
        image.SetActive(true);
    }

    private void Update()
    {
        var videoPlayer = GetComponent<VideoPlayer>();
        if(videoPlayer.isPrepared)
        {
            image.SetActive(false);
            videoPlayer.Play();
        }
    }

    public void CarregarOpcoes(string _opcoes)
    {
        var videoPlayer = GetComponent<VideoPlayer>();
        switch (_opcoes)
        {
            case "Parou":
                videoPlayer.Stop();
                image.SetActive(true);
                Time.timeScale = 1f;
                if (EscolhaASuaSerie.cena == 1)
                {
                    Carregamento.cenaACarregar = "Fase_01";
                    SceneManager.LoadScene("Carregamento");
                }
                else if (EscolhaASuaSerie.cena == 2)
                {
                    Carregamento.cenaACarregar = "Fase_01_2";
                    SceneManager.LoadScene("Carregamento");
                }
                else if (EscolhaASuaSerie.cena == 3)
                {
                    Carregamento.cenaACarregar = "Fase_01_3";
                    SceneManager.LoadScene("Carregamento");
                }
                else if (EscolhaASuaSerie.cena == 4)
                {
                    Carregamento.cenaACarregar = "Fase_01_4";
                    SceneManager.LoadScene("Carregamento");
                }
                else if (EscolhaASuaSerie.cena == 5)
                {
                    Carregamento.cenaACarregar = "Fase_01_5";
                    SceneManager.LoadScene("Carregamento");
                }
                break;
        }
    }
}
