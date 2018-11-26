using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour {

    private Animator anim;

    public float playerDistancia;
    public float ataqueDistancia;
    public GameObject player;

    public GameObject PrefabProjetil;
    public Transform instanciador;
    private bool bobCorreu;
    public float velocidade;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        ataqueDistancia = 8.5f;
        bobCorreu = false;
        velocidade = 10;
}
	
	// Update is called once per frame
	void Update () {

        playerDistancia = transform.position.x - player.transform.position.x;

        if (Mathf.Abs(playerDistancia) < ataqueDistancia)
        {
            BobAtaca();
            }

        if (bobCorreu)
        {
            transform.Translate(velocidade * Time.deltaTime, 0, 0);
            SomeBob();
        }
    }

        

    public void BobAtaca()
    {
        anim.SetBool("bobAtacando", true);
    }


    public void TiroBob()
    {
        GameObject temp = (Instantiate(PrefabProjetil, instanciador.position, instanciador.rotation));

        temp.GetComponent<Bala>().Inicializar(Vector2.left);
    }


    void BobCorre()
    {
        anim.SetBool("bobCorrendo", true);
        bobCorreu = true;
    }


    void SomeBob()
    {
        Destroy(gameObject, 30);
    }
 }

