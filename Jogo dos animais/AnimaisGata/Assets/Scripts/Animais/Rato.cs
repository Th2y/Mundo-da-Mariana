using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rato : MonoBehaviour
{
    public Transform DetectaChao;
    public float distancia;
    public bool isLookLeft;
    public float velocidadeInicial;
    private float velocidade;
    private Animator ratoAnimator;
    private GameObject queijo;
    private bool achouOQueijo;
    private bool podePatrulhar;
    private bool voltar;

    void Start()
    {
        velocidade = velocidadeInicial;
        podePatrulhar = true;
        voltar = true;
        isLookLeft = true;
        ratoAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (achouOQueijo == false)
        {
            if(podePatrulhar == true)
                Patrulha();
        }
        else
        {
            if (achouOQueijo == true)
                velocidadeInicial = 0;
            if (queijo == null)
            {
                velocidadeInicial = velocidade;
                voltar = false;
                achouOQueijo = false;
                if (transform.eulerAngles.y == 0)
                {
                    transform.eulerAngles = new Vector3(0, -180, 0);
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
            }
        }
    }

    private void FixedUpdate()
    {
        if (velocidadeInicial != 0)
            ratoAnimator.SetInteger("x", (int)velocidadeInicial);
        else
            ratoAnimator.SetInteger("x", 0);
    }

    public void Patrulha()
    {
        transform.Translate(Vector2.right * velocidadeInicial * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(DetectaChao.position, Vector2.right, distancia);
        if (groundInfo.collider != null)
        {
            if(groundInfo.collider.CompareTag("ratoVe"))
            {
                if(voltar == true)
                {
                    podePatrulhar = true;
                    if (isLookLeft == true)
                    {
                        transform.eulerAngles = new Vector3(0, -180, 0);
                        isLookLeft = false;
                    }
                    else
                    {
                        transform.eulerAngles = new Vector3(0, 0, 0);
                        isLookLeft = true;
                    }
                }
                else
                    podePatrulhar = false;
            }
            else
            {
                if (groundInfo.collider.CompareTag("queijo"))
                {
                    achouOQueijo = true;
                    queijo = groundInfo.collider.gameObject;
                    Debug.Log("Achou o queijo");
                }
            }
        }
    }

    void OnDrawGizmos()
    {
        Vector3 origem = DetectaChao.position;
        Vector3 destino = DetectaChao.position;
        destino.x += distancia;
        Gizmos.DrawLine(origem, destino);
    }
}