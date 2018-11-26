using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorTrigger : MonoBehaviour {

    private Jogador jogador;
    private Agente agente;
    private Sentinela sentinela;

    // Use this for initialization

    private void Awake()
    {
        jogador = GameObject.Find("Player").GetComponent<Jogador>();
        agente = GameObject.Find("Inimigo").GetComponent<Agente>();
        sentinela = GameObject.Find("Sentinela").GetComponent<Sentinela>();
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("BalaInimigo"))
        {
            if (!jogador.invulnerabilidade)
            {
                jogador.DanoJogador(agente.danoAgente);
               
            }
        }

        if (collision.CompareTag("Sentinela"))
        {
            if (!jogador.invulnerabilidade)
            {
                jogador.DanoJogador(sentinela.danoSentinela);
            }
        }
    }
}
