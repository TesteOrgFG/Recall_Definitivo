using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour {

    Image barraVida;
    float vidaMaxima = 1f;
    public static float vida;

	// Use this for initialization
	void Start () {
        barraVida = GetComponent<Image>();
        vida = vidaMaxima;
	}
	
	// Update is called once per frame
	void Update () {

        barraVida.fillAmount = vida / vidaMaxima;
	}
}
