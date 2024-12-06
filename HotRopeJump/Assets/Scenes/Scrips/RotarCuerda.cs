using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarCuerda : MonoBehaviour
{
    public float velocidadRotacion = 100f;   // Velocidad inicial de rotación
    public float aumentoVelocidad = 10f;    // Cantidad de aumento por segundo
    public float maxVelocidad = 350f;        // Velocidad máxima que puede alcanzar
    public float minVelocidad = 50f;         // Velocidad mínima después de reducirla aleatoriamente
    public float tiempoParaCambiar = 10f;    // Tiempo en segundos para cambiar la velocidad aleatoriamente

    public ContadorVueltas contadorVueltas;

    private float tiempoActual = 0f;
    private float rotacionActual = 0f;

    void FixedUpdate()
    {
        // Rotar la cuerda en el eje X
        transform.Rotate(Vector3.right * velocidadRotacion * Time.fixedDeltaTime);

        // Aumentar la velocidad de rotación
        velocidadRotacion = Mathf.Min(velocidadRotacion + aumentoVelocidad * Time.fixedDeltaTime, maxVelocidad);

        // Controlar el cambio de velocidad aleatorio después de un tiempo
        tiempoActual += Time.fixedDeltaTime;
        if (tiempoActual >= tiempoParaCambiar)
        {
            // Reiniciar el contador
            tiempoActual = 0f;

            // Cambiar la velocidad de rotación aleatoriamente entre un rango definido
            velocidadRotacion = Random.Range(minVelocidad, maxVelocidad);
        }

        // Actualizar el contador de rotación
        rotacionActual += velocidadRotacion * Time.fixedDeltaTime;

        // Comprobar si ha dado una vuelta completa
        if (rotacionActual >= 360f)
        {
            rotacionActual -= 360f; // Resetea el contador
            contadorVueltas.IncrementarVueltas(); // Llama al método del contador para incrementar
        }
    }
}
