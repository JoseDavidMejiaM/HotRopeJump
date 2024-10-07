using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarCuerda : MonoBehaviour
{
    public float velocidadRotacion = 100f;   // Velocidad inicial de rotaci�n
    public float aumentoVelocidad = 10f;    // Cantidad de aumento por segundo
    public float maxVelocidad = 350f;        // Velocidad m�xima que puede alcanzar
    public float minVelocidad = 50f;         // Velocidad m�nima despu�s de reducirla aleatoriamente
    public float tiempoParaCambiar = 10f;    // Tiempo en segundos para cambiar la velocidad aleatoriamente

    public ContadorVueltas contadorVueltas; // Referencia al script de contador de vueltas

    private float tiempoActual = 0f;         // Contador para el cambio de velocidad
    private float rotacionActual = 0f;       // Contador de rotaci�n actual

    void FixedUpdate()
    {
        // Rotar la cuerda en el eje X
        transform.Rotate(Vector3.right * velocidadRotacion * Time.fixedDeltaTime);

        // Aumentar gradualmente la velocidad de rotaci�n hasta alcanzar la velocidad m�xima
        velocidadRotacion = Mathf.Min(velocidadRotacion + aumentoVelocidad * Time.fixedDeltaTime, maxVelocidad);

        // Controlar el cambio de velocidad aleatorio despu�s de un tiempo
        tiempoActual += Time.fixedDeltaTime;
        if (tiempoActual >= tiempoParaCambiar)
        {
            // Reiniciar el contador
            tiempoActual = 0f;

            // Cambiar la velocidad de rotaci�n aleatoriamente entre un rango definido
            velocidadRotacion = Random.Range(minVelocidad, maxVelocidad);
        }

        // Actualizar el contador de rotaci�n
        rotacionActual += velocidadRotacion * Time.fixedDeltaTime;

        // Comprobar si ha dado una vuelta completa
        if (rotacionActual >= 360f)
        {
            rotacionActual -= 360f; // Resetea el contador
            contadorVueltas.IncrementarVueltas(); // Llama al m�todo del contador para incrementar
        }
    }
}
