using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PegarNome : MonoBehaviour
{
    public Text jogador;
    public string nomeDaCena;

    void Start()
    {
        nomeDaCena = SceneManager.GetActiveScene().name;
        jogador.text = SalvarNome.jogador;
    }
}
