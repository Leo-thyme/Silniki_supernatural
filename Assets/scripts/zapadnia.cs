using Unity.VisualScripting;
using UnityEngine;

public class zapadnia : MonoBehaviour
{
    
    public bramka bramka;
    public MeshRenderer ZapRen;
    public MeshRenderer star;

    public void Start()
    {
        ZapRen.enabled = true;
        bramka = FindAnyObjectByType<bramka>();
    }

    public void Update()
    {
        if (bramka.gol == true)
        {
            ZapRen.gameObject.SetActive(false);
        }

    }
}
