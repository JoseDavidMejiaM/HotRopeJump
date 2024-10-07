using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPeach : MonoBehaviour
{
    private Animator anim;
    public float x, y;
    public Rigidbody rb;
    public float fuerzaSalto = 10f;
    public bool puedoSaltar;

    // Tecla de salto personalizada para cada personaje
    public KeyCode teclaSalto = KeyCode.Space;


    public AudioSource audioSource;  // El AudioSource que reproducirá los sonidos
    public AudioClip sonidoSalto;    // El clip de sonido para el salto
    public AudioClip sonidoMuerte;  // El clip de sonido para la muerte

    // Start is called before the first frame update
    void Start()
    {
        puedoSaltar = false;
        anim = GetComponent<Animator>();
        gameObject.tag = "PersonajeVivo";
    }

    void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        if (puedoSaltar)
        {
            if (Input.GetKeyDown(teclaSalto))
            {
                audioSource.PlayOneShot(sonidoSalto);  // Reproduce el sonido del salto
                anim.SetBool("estaSaltando", true);
                rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
                anim.SetBool("TocaSuelo", true);
            }
            anim.SetBool("TocaSuelo", true);
        }
        else
        {
            EstoyCayendo();
        }
    }
    public void EstoyCayendo()
    {
        anim.SetBool("estaSaltando", false);
        anim.SetBool("TocaSuelo", false);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CuerdaDeFuego")) // Si la cuerda de fuego tiene la etiqueta "Fuego"
        {
            Morir();
        }
    }

    private void Morir()
    {
        audioSource.PlayOneShot(sonidoMuerte);  // Reproduce el sonido de muerte
        anim.SetTrigger("Morir");
        gameObject.tag = "PersonajeMuerto";
        if (rb != null)
        {
            rb.isKinematic = true; // Desactiva las físicas para que no lo afecten más
        }
        rb.isKinematic = true; // Desactiva las físicas para que no lo afecten más
        Destroy(gameObject, 2f);
    }


}
