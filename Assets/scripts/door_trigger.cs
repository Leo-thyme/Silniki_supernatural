using UnityEngine;

public class door_trigger : MonoBehaviour
{
    bool is_in_trigger = false;
    bool door_closed = true;
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            is_in_trigger = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            is_in_trigger = false;
        }
    }

    private void Update()
    {
        if (is_in_trigger == true && Input.GetKeyDown(KeyCode.E))
        {
            if (door_closed == true) 
            {
                door_closed = false;
                animator.SetBool("Is_close",door_closed);
            }
            else
            {
                door_closed = true;
                animator.SetBool("Is_close", door_closed);
            }
        }


    }
}
