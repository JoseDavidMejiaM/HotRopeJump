using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorJuego : MonoBehaviour
{
    public MenuInicio menuInicio;
    public Text textoGanador; // Referencia al texto que mostrará el personaje ganador

    private ControladorAudio controladorAudio; // Referencia al controlador de audio
    public GameObject cuerdaDeFuego;
    public bool ganar;

    void Start()
    {
        controladorAudio = FindObjectOfType<ControladorAudio>(); // Busca el controlador de audio en la escena
    }

    void Update()
    {
        // Busca todos los personajes con el tag "PersonajeVivo"
        GameObject[] personajesVivos = GameObject.FindGameObjectsWithTag("PersonajeVivo");

        // Si no queda ningún personaje vivo, termina el juego sin ganador
        if (personajesVivos.Length == 0)
        {
            Debug.Log("Reproducir Musica Derrota");
            ganar= false;
            textoGanador.text = "¡No hay ganadores!";
            Destroy(cuerdaDeFuego, 1f);
            Invoke("LlamarMetodoTerminar", 4f);
        }
        // Si solo queda uno vivo, termina el juego y muestra el ganador
        else if (personajesVivos.Length == 1)
        {
            Debug.Log("Reproducir Musica Victoria");  
            ganar=true;
            string ganador = personajesVivos[0].name;
            Destroy(cuerdaDeFuego, 1f);
            textoGanador.text = "¡El ganador es: " + ganador + "!";
            Invoke("LlamarMetodoTerminar", 5f);
        }
    }

    public void LlamarMetodoTerminar()
    {
        if (ganar is true)
        {
            controladorAudio.ReproducirMusicaVictoria();
        }
        else {
            controladorAudio.ReproducirMusicaDerrota();
        }
        menuInicio.TerminarJuego();
    }
}