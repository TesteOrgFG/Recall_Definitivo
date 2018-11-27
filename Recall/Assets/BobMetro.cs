using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobMetro : MonoBehaviour
{

    private Animator anim;

    public float playerDistancia;
    public float ataqueDistancia;
    public GameObject player;

    public GameObject PrefabProjetil;
    public Transform instanciador;
    private bool bobCorreu;
    public float velocidade;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        ataqueDistancia = 4f;

    }

    // Update is called once per frame
    void Update()
    {

        playerDistancia = transform.position.x - player.transform.position.x;

        if (Mathf.Abs(playerDistancia) < ataqueDistancia)
        {
            anim.SetBool("bobRende", true);
        }


    }
}
