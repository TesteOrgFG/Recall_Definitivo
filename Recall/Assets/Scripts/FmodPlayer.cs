using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FmodPlayer : MonoBehaviour
{
    FMOD.Studio.EventInstance M_Casa, M_Grama, M_Bar, M_Chase, M_Sangue;

    public enum Estado { MADEIRA, CONCRETO, GRAMA }
    public Estado footstep;

    void Start()
    {
        M_Casa = FMODUnity.RuntimeManager.CreateInstance("event:/SOUND TRACK/Porta 1/Casa/Casa");
        M_Grama = FMODUnity.RuntimeManager.CreateInstance("event:/SOUND TRACK/Porta 1/Grama/Grama");
        M_Bar = FMODUnity.RuntimeManager.CreateInstance("event:/SOUND TRACK/Porta 2/Bar/Bar");
        M_Chase = FMODUnity.RuntimeManager.CreateInstance("event:/SOUND TRACK/Porta 2/Perseguição/Chase");
        M_Sangue = FMODUnity.RuntimeManager.CreateInstance("event:/SOUND TRACK/Porta 1/Sangue/Sangue");
    }
    
    void PlaySound()
    {
        if (footstep == Estado.MADEIRA)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Doug/Foosteps/Madeira/FootstepWood", GetComponent<Transform>().position);
        }

        if (footstep == Estado.CONCRETO)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Doug/Foosteps/Concreto/FootstepConcret", GetComponent<Transform>().position);
        }

        if (footstep == Estado.GRAMA)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Doug/Foosteps/Grama/FootstepGrass", GetComponent<Transform>().position);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Metro1")
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/SOUND TRACK/Metro/Metro 1", GetComponent<Transform>().position);
        }

        if (collision.tag == "Metro2")
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/SOUND TRACK/Metro/Metro 2", GetComponent<Transform>().position);
        }

        if (collision.tag == "Musica Casa")
        {
            M_Casa.start();
        }

        if (collision.tag == "Musica Grama")
        {
            M_Grama.start();
        }

        if (collision.tag == "Musica Bar")
        {
            M_Bar.start();
        }

        if (collision.tag == "Musica Chase")
        {
            M_Chase.start();
        }

        if (collision.tag == "Footstep Madeira")
        {
            footstep = Estado.MADEIRA;
        }

        if (collision.tag == "Footstep Concreto")
        {
            footstep = Estado.CONCRETO;
        }

        if (collision.tag == "Footstep Grama")
        {
            footstep = Estado.GRAMA;
        }

        if (collision.tag == "Limbo3")
        {
            M_Chase.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Footstep Madeira")
        {
            footstep = Estado.MADEIRA;
        }

        if (collision.tag == "Footstep Concreto")
        {
            footstep = Estado.CONCRETO;
        }

        if (collision.tag == "Footstep Grama")
        {
            footstep = Estado.GRAMA;
        }

        if (collision.tag == "Limbo3")
        {
            M_Chase.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Musica Casa")
        {
            M_Casa.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }

        if (collision.tag == "Musica Grama")
        {
            M_Grama.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }

        if (collision.tag == "Musica Bar")
        {
            M_Bar.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }

        if (collision.tag == "Musica Chase" || collision.tag == "Limbo3")
        {
            M_Chase.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }


    }
}
