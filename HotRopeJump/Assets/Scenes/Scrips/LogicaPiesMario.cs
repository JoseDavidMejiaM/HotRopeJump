using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPiesMario : MonoBehaviour
{
    public LogicaMario mario;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        mario.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        mario.puedoSaltar = false;
    }
}
