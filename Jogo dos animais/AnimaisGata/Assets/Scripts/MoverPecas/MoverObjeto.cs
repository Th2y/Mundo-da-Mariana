using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjeto : MonoBehaviour
{   
    Vector3 posicaoInicial;
    Vector3 posicaoDestino;
    Vector3 vetorDirecao;

    Rigidbody2D rigidbodyO;
    bool estaArrastando;
    float distancia;
    [HideInInspector]
    public bool estaConectado;

    [Range(1,15)]
    public float velocidadeDeMovimento = 10;
    public Transform conector;
    [Range(0.1f, 2.0f)]
    public float distanciaMinConector = 0.5f;

    void Start()
    {
        rigidbodyO = transform.root.GetComponent<Rigidbody2D>();
        rigidbodyO.gravityScale = 0;
    }

    void OnMouseDown()
    {
        posicaoInicial = transform.root.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rigidbodyO.gravityScale = 0;
        estaArrastando = true;
        estaConectado = false;
    }

    void OnMouseDrag()
    {
        posicaoDestino = posicaoInicial + Camera.main.ScreenToWorldPoint(Input.mousePosition);
        vetorDirecao = posicaoDestino - transform.root.position;
        rigidbodyO.velocity = vetorDirecao * velocidadeDeMovimento;
    }

    void OnMouseUp()
    {
        rigidbodyO.gravityScale = 1;
        estaArrastando = false;
    }

    void FixedUpdate()
    {
        if(!estaArrastando && !estaConectado)
        {
            distancia = Vector2.Distance(transform.root.position, conector.position);

            if(distancia < distanciaMinConector)
            {
                rigidbodyO.gravityScale = 0;
                rigidbodyO.velocity = Vector2.zero;
                transform.root.position = Vector2.MoveTowards(transform.root.position, conector.position, 0.02f);
            }

            if(distancia < 0.01f)
            {
                estaConectado = true;
                transform.root.position = conector.position;

                if(estaConectado)
                    velocidadeDeMovimento = 0;
            }
        }
    }
}
