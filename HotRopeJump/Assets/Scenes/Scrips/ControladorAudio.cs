using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip musicaFondo;
    public AudioClip musicaVictoria;
    public AudioClip musicaDerrota;

    void Start()
    {
        ReproducirMusicaFondo();
    }

    // Método para reproducir la música de fondo
    public void ReproducirMusicaFondo()
    {
        audioSource.clip = musicaFondo;
        audioSource.loop = true;
        audioSource.Play();
    }

    // Método para reproducir la música de victoria
    public void ReproducirMusicaVictoria()
    {
        audioSource.Stop();

        audioSource.mute = false;
        audioSource.clip = musicaVictoria;
        audioSource.loop = false;
        audioSource.Play();
    }

    public void ReproducirMusicaDerrota()
    {
        audioSource.Stop();

        audioSource.mute = false;
        audioSource.clip = musicaDerrota;
        audioSource.loop = false;
        audioSource.Play();
    }

}
