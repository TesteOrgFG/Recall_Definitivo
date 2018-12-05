using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interage2 : MonoBehaviour {

    public bool entrouDialogo;
    public static bool Dialogo;
    public static bool m1, m2, m3, m4, m5, m6, m7;

    void Start()
    {
        Dialogo = false;
        m2 = true;
    }

    void Update()
    {
        if (entrouDialogo == true && m2 == true)
        {
            Dialogo = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("Entrou Dialogo");
            entrouDialogo = true;
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Radio/Radio", GetComponent<Transform>().position);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        print("Ficou Dialogo");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("saiu Dialogo");
            entrouDialogo = false;
        }
    }
}
