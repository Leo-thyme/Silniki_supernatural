using UnityEngine;

public class Trigger : MonoBehaviour
{
    private bool isInTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Gracz w triggerze");
            isInTrigger = true;
        }
        
     
    }

    private void OnTriggerExit(Collider other)
    {
        
        if(other.tag == "Player")
        {
            Debug.Log("Gracz poza triggerem");
            isInTrigger = false;
        }
    }

    private void Update()
    {
        if(isInTrigger)
        {
            Debug.Log("in Trigger");

        }
    }

}
