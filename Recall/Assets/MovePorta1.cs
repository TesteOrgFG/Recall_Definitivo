using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MovePorta1 : MonoBehaviour
{
    bool entrou;

    [SerializeField] private string newLevel;


    void Update()
    {
        if (entrou == true)
        {
            SceneManager.LoadScene(newLevel);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("Entrou");
            entrou = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        print("Ficou");
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("saiu");
            entrou = false;
        }
    }
}

