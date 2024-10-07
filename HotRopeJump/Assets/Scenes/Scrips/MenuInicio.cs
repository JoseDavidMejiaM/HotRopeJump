using UnityEngine;
using UnityEngine.UI;

public class MenuInicio : MonoBehaviour
{
    public GameObject menuInicio;
    public GameObject mensajeFin; 
    public Button botonReiniciar;

    void Start()
    {
        // Pausa el juego al inicio
        Time.timeScale = 0f;
        mensajeFin.SetActive(false);
    }

    public void IniciarJuego()
    {
        menuInicio.SetActive(false);
        Time.timeScale = 1f; // Despausa el juego
    }

    public void TerminarJuego()
    {
        mensajeFin.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ReiniciarJuego()
    {
        // Reinicia la escena actual
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
