using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraEscudo : MonoBehaviour {

    Image barraEscudo;
    float escudoMaximo = 1f;
    public static float escudo;

    // Use this for initialization
    void Start()
    {
        barraEscudo = GetComponent<Image>();
        escudo = escudoMaximo;
    }

    // Update is called once per frame
    void Update()
    {
        barraEscudo.fillAmount = escudo / escudoMaximo;
    }
}
