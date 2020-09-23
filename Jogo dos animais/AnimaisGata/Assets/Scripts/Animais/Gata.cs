using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gata : MonoBehaviour
{
    [SerializeField]
    private FixedJoystick joystickH;

    private float forcaSubir;
    public float forcaSubirMaior;
    public float forcaSubirMenor;
    public Button pulo;

    public float velocidadeMovimento;
    private Rigidbody2D gataRB;
    //private Animator gataAnimator;
    public bool isLookLeft;

    public AudioSource audios;
    public AudioSource comendoAudio;

    public AudioClip[] somComendo;

    public Text TextColetaveis;
    public static int contarColetaveis;
    public int contadorColetaveis;

    public GameObject chat;
    public GameObject pergunta01;
    public GameObject pergunta03;
    public GameObject pergunta04;

    public static float horizontal;
    public static float velocidadeX;

    void Start() 
    {
        gataRB = GetComponent<Rigidbody2D>();
        //gataAnimator = GetComponent<Animator>();
        contarColetaveis = contadorColetaveis;
        TextColetaveis.text = contadorColetaveis.ToString();
        chat.SetActive(false);
        pergunta01.SetActive(false);
        pergunta03.SetActive(false);
        pergunta04.SetActive(false);
        Button pular = pulo.GetComponent<Button>();
        //pular.onClick.AddListener(Clicando);
        pulo.interactable = false;
    }

    public void Clicando()
    {
        gataRB.AddForce(Vector3.up * forcaSubir, ForceMode2D.Impulse);
        pulo.interactable = false;
    }

    void Update()
    {
        horizontal = joystickH.Horizontal;

        velocidadeX = (horizontal * this.velocidadeMovimento);
        Vector2 velocidade = new Vector2(velocidadeX, gataRB.velocity.y);
        this.gataRB.velocity = velocidade;

        if(horizontal>0 && isLookLeft == false)
            FLip();
        else if(horizontal<0 && isLookLeft == true)
            FLip();
    }

    void playMusica(AudioClip somClip)
    {
        audios.PlayOneShot(somClip);
    }

    void FLip()
    {
        isLookLeft = !isLookLeft;

        float x = transform.localScale.x*-1;
        transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "peixe")
        {
            comendoAudio.PlayOneShot(somComendo[Random.Range(0, somComendo.Length)]);
            Destroy(other.gameObject);
            contadorColetaveis++;
            TextColetaveis.text = contadorColetaveis.ToString();
            contarColetaveis = contadorColetaveis;
        }

        if (other.gameObject.tag == "dialogo")
        {
            chat.SetActive(true);
            Destroy(other.gameObject);
            PausarParaPerguntar.emPergunta = true;
        }

        if(other.gameObject.tag == "pergunta01")
        {
            pergunta01.SetActive(true);
            Destroy(other.gameObject);
            PausarParaPerguntar.emPergunta = true;
        }

        if (other.gameObject.tag == "pergunta03")
        {
            pergunta03.SetActive(true);
            Destroy(other.gameObject);
            PausarParaPerguntar.emPergunta = true;
        }

        if (other.gameObject.tag == "pergunta04")
        {
            pergunta04.SetActive(true);
            Destroy(other.gameObject);
            PausarParaPerguntar.emPergunta = true;
        }

        if (other.gameObject.tag == "puloMaior")
        {
            forcaSubir = forcaSubirMaior;
            pulo.interactable = true;
            //Debug.Log("Maior" + forcaSubirMaior);
        }

        if (other.gameObject.tag == "puloMenor")
        {
            forcaSubir = forcaSubirMenor;
            pulo.interactable = true;
            //Debug.Log("Menor" + forcaSubirMenor);
        }

        if(other.gameObject.tag == "descer")
        {
            gataRB.gravityScale = 6;
        }
        if(other.gameObject.tag == "normalizar")
        {
            gataRB.gravityScale = 1;
        }
    }
}