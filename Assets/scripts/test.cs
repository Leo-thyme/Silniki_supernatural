using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("string");
        Debug.LogWarning("Warning");
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.LogError("Error");
    }

    private void Awake()
    {
        Debug.Log("Awake");

    }

    private void OnEnable()
    {
        Debug.LogWarning("Enable");
    }

    private void OnDisable()
    {
        Debug.LogWarning("Disable");
    }

    private void OnDestroy()
    {
        Debug.LogError("Destroy");
    }


}
