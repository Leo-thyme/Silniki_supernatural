using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private bool isInTrigger = false;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Do not come any closer!");
            isInTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("you LEAVE???!!");
            isInTrigger = false;
        }
    }
}
