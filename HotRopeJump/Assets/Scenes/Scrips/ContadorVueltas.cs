using UnityEngine;
using UnityEngine.UI;

public class ContadorVueltas : MonoBehaviour
{
    public Text contadorText;
    private int vueltas;

    void Start()
    {
        vueltas = 0;
        ActualizarTexto();
    }

     public void IncrementarVueltas()
    {
        vueltas++;
        ActualizarTexto();
    }

    private void ActualizarTexto()
    {
        contadorText.text = vueltas.ToString();
    }
}
