using UnityEngine;

public class RotateFan : MonoBehaviour
{
    public float rotationSpeed = 100f; // Speed of rotation

    void Update()
    {
        // Rotate around the Z-axis
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
