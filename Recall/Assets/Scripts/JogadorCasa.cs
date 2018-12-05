using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JogadorCasa : MonoBehaviour
{

    Rigidbody2D rb;
    public int velocidadeJogador;
    Animator animator;
    public GameObject player; // gameobject para inserir o player e mudar a escala dele

    enum Estados {PARADO, ANDANDO}
    Estados estado;

    public enum Lado { DIREITA, ESQUERDA }
    public Lado lado;

    SpriteRenderer spriteJogador;
    bool travaCorrer;
    //SpriteRenderer spriteBraco;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        velocidadeJogador = 5;
        estado = Estados.ANDANDO;
        lado = Lado.DIREITA;
        spriteJogador = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        if (estado == Estados.ANDANDO)
        {
            Andando();
        }
    }

    void Andando()
    {
        Vector2 vel = rb.velocity;
        vel.x = Input.GetAxis("Horizontal") * velocidadeJogador;

        if (vel.x > 0)
        {
            lado = Lado.DIREITA;
        }

        if (vel.x < 0)
        {
            lado = Lado.ESQUERDA;
        }

        if (lado == Lado.ESQUERDA)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

        else if (lado == Lado.DIREITA)
        {
           GetComponent<SpriteRenderer>().flipX = false;
        }

        rb.velocity = vel;
        animator.SetInteger("Andando", (int)vel.x);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("Enter");
        if (collision.tag == "Plataforma_tag")
        {
            estado = Estados.PARADO;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        estado = Estados.ANDANDO;
    }



    void MaquinaDeEstados()
    {
        if (estado == Estados.PARADO)
        {
            if (estado == Estados.ANDANDO)
            {
                Andando();
            }
        }
    }
}



