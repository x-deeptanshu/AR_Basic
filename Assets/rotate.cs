using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public Vector3 rotationAxis = Vector3.up; // You can change the axis as needed

    void Update()
    {
        // Rotate the object around the specified axis
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
