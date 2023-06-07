using UnityEngine;

public class CircularMoving : MonoBehaviour
{
    public float speed = 2f; // Speed of rotation
    public float radius = 2f; // Radius of circle
    public Vector3 center; // Center of circle
    public float rotationSpeed = 1;

    public float angle; // Current angle

    void Start()
    {
        
    }

    void Update()
    {
        var a = angle * 180 / Mathf.PI;
        angle += speed * Time.deltaTime;
    // Increment angle based on speed and time
        Vector3 offset = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle)) * radius; // Calculate offset based on angle and 
        transform.position = center + offset; // Set position to center plus offset
        transform.RotateAround(center, Vector3.up, a);

        //transform.RotateAround(center, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
