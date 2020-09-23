using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    private const string login = "Luna Estúdios";
    private const string pass = "Luna";

    public Color verde;
    public Color vermelho;

    [SerializeField]
    private InputField usuarioField = null;
    [SerializeField]
    private InputField senhaField = null;
    [SerializeField]
    private Toggle lembrar = null;
    [SerializeField]
    private Text feedbackmsg = null;
    [SerializeField]
    private GameObject registro;

    void Start()
    {
        registro.SetActive(false);

        if(PlayerPrefs.HasKey("remember") && PlayerPrefs.GetInt("remember") == 1)
        {
            usuarioField.text = PlayerPrefs.GetString("rememberLogin");
            senhaField.text = PlayerPrefs.GetString("rememberPass");
        }
    }

    public void FazerLogin()
    {
        string usuario = usuarioField.text;
        string senha = senhaField.text;

        if(lembrar.isOn)
        {
            PlayerPrefs.SetInt("remember", 1);
            PlayerPrefs.SetString("rememberLogin", usuario);
            PlayerPrefs.SetString("rememberPass", senha);
        }

        if(usuario == login && senha == pass)
        {
            feedbackmsg.color = verde;
            feedbackmsg.text = "Login realizado com sucesso";
            SceneManager.LoadScene("Inicio");
        }
        else
        {
            feedbackmsg.color = vermelho;
            feedbackmsg.text = "Usuário ou senha inválidos";
            usuarioField.text = "";
            senhaField.text = "";
        }
    }

    public void Registrar()
    {
        registro.SetActive(true);
    }
}
