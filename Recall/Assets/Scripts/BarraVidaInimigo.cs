using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVidaInimigo : MonoBehaviour {

    Image barraVida;
    private float vidaMaxima = 1f;
    public static float vidaInimigo;

    Vector3 localScale;
	// Use this for initialization
	void Start () {

        barraVida = GetComponent<Image>();
        vidaInimigo = vidaMaxima;
    }
	
	// Update is called once per frame
	void Update () {
        barraVida.fillAmount = vidaInimigo / vidaMaxima;
    }
}