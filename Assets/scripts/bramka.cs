using UnityEngine;

public class bramka : MonoBehaviour
{
    public bool gol = false;
    public void Start()
    {
        gol = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pilka")
        {
            gol = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
