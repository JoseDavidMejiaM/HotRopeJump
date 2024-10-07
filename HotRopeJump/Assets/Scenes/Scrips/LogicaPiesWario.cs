using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPiesWario : MonoBehaviour
{
    public LogicaWario wario;
    private void OnTriggerStay(Collider other)
    {
        wario.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        wario.puedoSaltar = false;
    }
}
