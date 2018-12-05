using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mensagem1 : MonoBehaviour {

    Interage1 interagir;

    public GameObject panelBox;
    public TextAsset arquivo;
    public string[] texto;
    public Text textoMensagem;

    private int fimDaLinha;
    private int linhaAtual;

    public bool estaAtivo;

    // Use this for initialization
    void Start()
    {

        if (arquivo != null)
        {
            texto = (arquivo.text.Split('\n'));
        }

        if (fimDaLinha == 0)
        {
            fimDaLinha = texto.Length;
        }

        estaAtivo = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Interage1.Dialogo == true && Interage1.m1 == true)
        {
            Habilitar();
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (linhaAtual < fimDaLinha)
            {
                textoMensagem.text = texto[linhaAtual];
            }
            if (panelBox.activeSelf)
            {
                linhaAtual += 1;
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Doug/Click/Click", GetComponent<Transform>().position);
            }

        }

        if (linhaAtual > fimDaLinha)
        {
            linhaAtual = 0;
            Desabilitar();
        }
    }

    void Habilitar()
    {
        panelBox.SetActive(true);
    }

    void Desabilitar()
    {
        panelBox.SetActive(false);
        estaAtivo = false;
        Destroy(gameObject);
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Radio/Radio", GetComponent<Transform>().position);
    }
}
