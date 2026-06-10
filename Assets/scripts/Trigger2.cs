using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    private bool isInTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player in plane (Trigger 2)");
            isInTrigger = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            isInTrigger = false;
            Debug.Log("Player got out of the plane (Trigger 2");
            
        }
    }

    private void Update()
    {
        if (isInTrigger)
        {
            Debug.Log("player still in plane");

        }
    }
}
