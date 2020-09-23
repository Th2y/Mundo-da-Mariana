using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject painelOptions;
    public GameObject painelPoints;
    public GameObject painelHow;
    public GameObject painelCredits;
    public GameObject painelStore;
    public GameObject painelGames;
    public GameObject painelPlay;
    public GameObject painelSair;

    public void LoadOptions(string _option)
    {  
        switch (_option)
        {
            case "MUDAR":
                SceneManager.LoadScene("Inicio");
                break;

            case "PLAY GAME":
                painelPlay.SetActive(true);
                break;
            case "VOLTAR1":
                painelPlay.SetActive(false);
                break;


            case "NIVEL01":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Introducao";
                SceneManager.LoadScene("Carregamento");
                break;

            case "NIVEL02_PRIMEIRO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_02";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL02_SEGUNDO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_02_2";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL02_TERCEIRO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_02_3";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL02_QUARTO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_02_4";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL02_QUINTO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_02_5";
                SceneManager.LoadScene("Carregamento");
                break;

            case "NIVEL03_PRIMEIRO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_03";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL03_SEGUNDO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_03_2";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL03_TERCEIRO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_03_3";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL03_QUARTO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_03_4";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL03_QUINTO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_03_5";
                SceneManager.LoadScene("Carregamento");
                break;

            case "NIVEL04_PRIMEIRO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_04";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL04_SEGUNDO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_04_2";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL04_TERCEIRO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_04_3";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL04_QUARTO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_04_4";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL04_QUINTO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_04_5";
                SceneManager.LoadScene("Carregamento");
                break;

            case "NIVEL05_PRIMEIRO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_05";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL05_SEGUNDO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_05_2";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL05_TERCEIRO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_05_3";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL05_QUARTO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_05_4";
                SceneManager.LoadScene("Carregamento");
                break;
            case "NIVEL05_QUINTO":
                painelPlay.SetActive(false);
                Time.timeScale = 1f;
                Carregamento.cenaACarregar = "Fase_05_5";
                SceneManager.LoadScene("Carregamento");
                break;


            case "POINTS":
                painelPoints.SetActive(true);
                break;
            case "BACK1":
                painelPoints.SetActive(false);
                break;
            case "STORE":
                painelStore.SetActive(true);
                break;
            case "BACK4":
                painelStore.SetActive(false);
                break;
            case "GAMES":
                painelGames.SetActive(true);
                break;
            case "BACK5":
                painelGames.SetActive(false);
                break;
            case "OPTIONS":
                painelOptions.SetActive(true);
                break;
            case "BACK":
                painelOptions.SetActive(false);
                break;
            case "COMO":
                painelOptions.SetActive(false);
                painelHow.SetActive(true);
                break;
            case "BACK2":
                painelOptions.SetActive(true);
                painelHow.SetActive(false);
                break;
            case "CREDITOS":
                painelOptions.SetActive(false);
                painelCredits.SetActive(true);
                break;
            case "BACK3":
                painelOptions.SetActive(true);
                painelCredits.SetActive(false);
                break;

            case "QUIT":
                painelSair.SetActive(true);
                break;
            case "SIM":
                Application.Quit();
                break;
            case "NAO":
                painelSair.SetActive(false);
                break;
        }
    }
}
