using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPausar : MonoBehaviour
{
    public GameObject painelPausa;
    public GameObject painelSair;

    public static bool JogoEmPausa = false;

    public void CarregarOpcoes(string _opcoes)
    {
        switch (_opcoes)
        {
            case "PAUSOU":
                Pause();
                break;
            case "VOLTAR A JOGAR":
                Resume();
                break;
            case "MENU":
                SceneManager.LoadScene("Menu");
                break;
            case "MENU_2":
                SceneManager.LoadScene("Menu_2");
                break;
            case "MENU_3":
                SceneManager.LoadScene("Menu_3");
                break;
            case "MENU_4":
                SceneManager.LoadScene("Menu_4");
                break;
            case "MENU_5":
                SceneManager.LoadScene("Menu_5");
                break;

            case "SAIR":
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

    void Pause()
    {
        painelPausa.SetActive(true);
        Time.timeScale = 0f;
        JogoEmPausa = true;
    }

    public void Resume()
    {
        painelPausa.SetActive(false);
        Time.timeScale = 1f;
        JogoEmPausa = false;
    }
}
