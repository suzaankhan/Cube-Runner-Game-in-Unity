

using UnityEngine.UI;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody rb;
    public Text gameOverText;
    public playerScript movement;
    
    public float forwardForce = 2000f;
    public float movementForce = 700f;
    public float jumpForce = 10f; // Added jump force
    public float temp;

    private bool isGrounded = true; // To check if the player is grounded

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Add forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Move right if 'd' is pressed
        if (Input.GetKey("d"))
        {
            rb.AddForce(movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Move left if 'a' is pressed
        if (Input.GetKey("a"))
        {
            rb.AddForce(-movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Jump when space is pressed and the player is grounded
        // if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        if (Input.GetKey("s") && isGrounded)
        {
            temp = forwardForce;
            forwardForce = 700f;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // Set grounded to false while in the air
        }

        if(rb.position.y < -1){
            gameOverText.text = "GAME OVER";
            movement.enabled = false;
            rb.isKinematic = true; // Disable physics interactions
        }
    }

    // Check if the player has collided with the ground
    private void OnCollisionEnter(Collision collision)
    {
        // Assuming the ground has a tag called "Ground"
        if (collision.collider.name == "Playground")
        {
            Debug.Log("Player hit the ground");
            forwardForce = temp;
            isGrounded = true; // Player can jump again once they hit the ground
        }
    }
}

