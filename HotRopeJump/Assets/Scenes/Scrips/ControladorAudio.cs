using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip musicaFondo;
    public AudioClip musicaVictoria;

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

        // Cambiar la música a la de victoria
        audioSource.clip = musicaVictoria;
        audioSource.loop = false; // Reproducir una sola vez
        audioSource.Play();
    }
}
