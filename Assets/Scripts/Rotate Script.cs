using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 1, 0); // Rotation speed for each axis

    void Update()
    {
        // Rotate the object by the rotation speed multiplied by time.deltaTime
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}