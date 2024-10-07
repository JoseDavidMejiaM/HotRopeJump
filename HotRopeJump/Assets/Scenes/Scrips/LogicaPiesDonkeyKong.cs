using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPiesDonkeyKong : MonoBehaviour
{
    public LogicaDonkeyKong donkeyKong;
    private void OnTriggerStay(Collider other)
    {
        donkeyKong.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        donkeyKong.puedoSaltar = false;
    }
}
