using UnityEngine;

public class DayCycleRotator : MonoBehaviour
{
    public Transform rotator;
    [Range(0,1000)]
    public float rotationValue;

    private void Update()
    {
        rotator.Rotate(new Vector3(0, 0, rotationValue * Time.deltaTime));

    }
}
