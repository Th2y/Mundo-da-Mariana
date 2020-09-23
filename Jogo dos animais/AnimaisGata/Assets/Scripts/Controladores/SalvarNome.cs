using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SalvarNome : MonoBehaviour
{
    public GameObject[] paineis;
    public InputField nome;
    public static string jogador;
    public Button confirmarNome;
    public string nomeDaCena;

    void Start()
    {
        nomeDaCena = SceneManager.GetActiveScene().name;
        nome.text = PlayerPrefs.GetString("Nome");
        jogador = nome.text;
        if (nomeDaCena == "Inicio")
        {
            paineis[0].SetActive(true);
            paineis[1].SetActive(false);
            confirmarNome.interactable = false;
        }
    }

    public void Nome()
    {
        if (nomeDaCena == "Inicio")
        {
            PlayerPrefs.SetString("Nome", nome.text);
            if(nome.text != "")
                confirmarNome.interactable = true;
        }
    }

    public void Confirmar()
    {
        if (nomeDaCena == "Inicio")
        {
            paineis[0].SetActive(false);
            paineis[1].SetActive(true);
        }
    }
}
