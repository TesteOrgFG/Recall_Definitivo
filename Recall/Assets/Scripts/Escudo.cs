using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : MonoBehaviour {

    Jogador jogador;
    

    private void Start()
    {
        jogador = GetComponentInParent<Jogador>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BalaInimigo"))
        {
           // print("ACERTOU O ESCUDO");

            //INSERIR SOM DA BALA BATENDO NO ESCUDO AQUI

            jogador.vidaEscudo -= 0.2f;
            BarraEscudo.escudo -= 0.2f;
            jogador.tempoSemTomarDano = 0;    
        }

        if (collision.tag == "Sentinela")
        {
            // INSERIR SOM DA SENTINELA BATENDO NO ESCUDO AQUI (ACHO QUE SERÁ O MESMO SOM)

           jogador.vidaEscudo -= 0.3f;
           BarraEscudo.escudo -= 0.3f;
           jogador.tempoSemTomarDano = 0;
        }
    }   
}
