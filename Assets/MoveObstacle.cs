using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public float speed = 10f; // Speed of movement
    private float targetX; // The target position on the x-axis
    [SerializeField]
    private float minX = -5.9f; // Minimum x value
    [SerializeField]
    private float maxX = 5.9f; // Maximum x value

    void Start()
    {
        targetX = maxX; // Start moving towards maxX
    }

    void Update()
    {
        // Move the obstacle towards the target position
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetX, transform.position.y, transform.position.z), speed * Time.deltaTime);
        
        // Check if the obstacle has reached the target position
        if (Mathf.Abs(transform.position.x - targetX) < 0.01f)
        {
            // Switch the target position
            targetX = (targetX == maxX) ? minX : maxX;
        }
    }
}
