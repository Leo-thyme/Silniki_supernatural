using System.ComponentModel;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Trigger3 : MonoBehaviour
{
    private bool isInTrigger = false;

    public MeshRenderer Tr3;

    private void Start()
    {
        //Tr3 = GetComponent<MeshRenderer>();
        Tr3.enabled = true;

    }
    private void OnTriggerEnter(Collider other)
    {
        
        

        if (other.tag == "Player")
        {
            Debug.Log("Now you won't find it!!!");
            isInTrigger = true;

            Tr3.enabled = false;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("no! wait! come back!");
            isInTrigger = false;

            Tr3.enabled = true;
        }
        


    }

    
}
