using UnityEngine;

public class CircularMoving : MonoBehaviour
{
    public float speed = 2f; // Speed of rotation
    public float radius = 2f; // Radius of circle
    public Vector3 center; // Center of circle
    public float rotationSpeed = 2;

    public float degAngle;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        var angle = degAngle;
        Vector3 offset = new Vector3(Mathf.Sin(DegToRad(angle)) * radius, 0, Mathf.Cos(DegToRad(angle)) * radius);
        transform.position = center + offset; 
        transform.RotateAround(center, Vector3.up, rotationSpeed);
        if (degAngle == 359.5)
        {
            degAngle = 0;
        }
        else
        {
            degAngle += rotationSpeed;
        }
    }

    private float DegToRad(float deg)
    {
        return deg * Mathf.PI / 180;
    }
}
