using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{

    public GameObject parent;
    public bool move = true;

    private void OnTriggerEnter(Collider other)
    {
        move = false;
        Debug.Log("Entered Trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        move = true;
        Debug.Log("Left Trigger");
    }

    public bool GetState()
    {
        return move;
    }
}
