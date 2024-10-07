using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPiesPeach : MonoBehaviour
{
    public LogicaPeach peach;
    private void OnTriggerStay(Collider other)
    {
        peach.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        peach.puedoSaltar = false;
    }
}
