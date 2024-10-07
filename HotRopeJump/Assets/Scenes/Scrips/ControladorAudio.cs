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

    // M�todo para reproducir la m�sica de fondo
    public void ReproducirMusicaFondo()
    {
        audioSource.clip = musicaFondo;
        audioSource.loop = true;
        audioSource.Play();
    }

    // M�todo para reproducir la m�sica de victoria
    public void ReproducirMusicaVictoria()
    {
        audioSource.Stop();

        audioSource.mute = false;

        // Cambiar la m�sica a la de victoria
        audioSource.clip = musicaVictoria;
        audioSource.loop = false; // Reproducir una sola vez
        audioSource.Play();
    }
}
