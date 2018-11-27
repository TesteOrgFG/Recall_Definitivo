using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvisosScript : MonoBehaviour {

    public bool entrouDialogo;

    public GameObject imagem1;
    public GameObject imagem2;
    public GameObject imagem3;
    public GameObject imagem4;

    void Start()
    {
        imagem1.gameObject.SetActive(false);
        imagem2.gameObject.SetActive(false);
        imagem3.gameObject.SetActive(false);
        imagem4.gameObject.SetActive(false);
    }

    void Update()
    {
        if (entrouDialogo == true)
        {
            imagem1.gameObject.SetActive(true);
            imagem2.gameObject.SetActive(true);
            imagem3.gameObject.SetActive(true);
            imagem4.gameObject.SetActive(true);
        }

        if (entrouDialogo == false)
        {
            imagem1.gameObject.SetActive(false);
            imagem2.gameObject.SetActive(false);
            imagem3.gameObject.SetActive(false);
            imagem4.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("Entrou Dialogo");
            entrouDialogo = true;
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
