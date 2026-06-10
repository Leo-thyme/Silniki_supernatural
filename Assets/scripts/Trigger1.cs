using System;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    private bool isInTrigger = false;
    public int points = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            Debug.Log("No!Do not jump!!!");
            isInTrigger = true;
            points = points + 1;
            Debug.Log("Your points: " + points);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") 
        {
            Debug.Log("you JUMPED????");
            isInTrigger = false;
        }
    }
}
