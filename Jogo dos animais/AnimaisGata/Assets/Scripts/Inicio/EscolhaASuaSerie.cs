using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Security.Principal;

public class EscolhaASuaSerie : MonoBehaviour
{
    public Dropdown dropdown;
    public Button confirmar;
    public static int cena;
    public string aceitar;
    public GameObject termo;
    
    void Start()
    {
        confirmar.interactable = false;
        aceitar = PlayerPrefs.GetString("Aceitou");

        if (PlayerPrefs.HasKey("Aceitou"))
            termo.SetActive(false);
    }

    private void Update()
    {
        Series();
    }

    public void Series()
    {
        switch(dropdown.value)
        {
            case 0:
                confirmar.interactable = false;
                break;
            case 1:
                confirmar.interactable = true;
                break;
            case 2:
                confirmar.interactable = true;
                break;
            case 3:
                confirmar.interactable = true;
                break;
            case 4:
                confirmar.interactable = true;
                break;
            case 5:
                confirmar.interactable = true;
                break;
        }
    }

    public void Confirmar(string opcoes)
    {
        if (opcoes == "Aceito")
        {
            PlayerPrefs.SetString("Aceitou", aceitar);
        }

        if (opcoes == "Discordo")
            Application.Quit();

        if (dropdown.value == 1)
        {
            cena = 1;
            opcoes = "1";
        }
        if (dropdown.value == 2)
        {
            cena = 2;
            opcoes = "2";
        }
        if (dropdown.value == 3)
        {
            cena = 3;
            opcoes = "3";
        }
        if (dropdown.value == 4)
        {
            cena = 4;
            opcoes = "4";
        }
        if (dropdown.value == 5)
        {
            cena = 5;
            opcoes = "5";
        }

        if (opcoes == "1")
        {
            SceneManager.LoadScene("Menu");
        }
        else if (opcoes == "2")
        {
            SceneManager.LoadScene("Menu_2");
        }
        else if (opcoes == "3")
        {
            SceneManager.LoadScene("Menu_3");
        }
        else if (opcoes == "4")
        {
            SceneManager.LoadScene("Menu_4");
        }
        else if (opcoes == "5")
        {
            SceneManager.LoadScene("Menu_5");
        }
    }
}
