using UnityEngine;

public class star : MonoBehaviour
{

    bool triggered = false;
    public GameObject Rend;

    

   
    private void OnTriggerEnter(Collider other)
    {
        triggered = true;
        Rend.SetActive(false);




    }
}
