using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoInimigo : MonoBehaviour
{
    [SerializeField]
    Collider2D outro;
    Agente agente;
    Weapon weapon;

    private void Awake()
    {
        agente = GetComponent<Agente>();

        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), outro, true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "BalaInimigo")
        {
            agente.DanoAgente(0.1f);
        }
    }
}
