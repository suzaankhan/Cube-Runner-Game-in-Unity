
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    private int jumpCount = 0;
    private int score;
    private bool isGrounded; 

    void Start()
    {
        // Initialize score
        score = 0;
        
        scoreText.text = score.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Update score based on player's position
        int currentPlayerZ = Mathf.FloorToInt(player.position.z + 40); // Adjust as needed
        int currentPlayerY = Mathf.FloorToInt(player.position.y); // Adjust as needed
        int bonus = 1000;
        bool giveBonus = false;
        int scoreMain = currentPlayerZ;
        bool updateJumpCount = true;

        if (currentPlayerY == 1)
        {
            isGrounded = true; // Player is on the ground
        }
        else
        {
            isGrounded = false; // Player is in the air
        }

        if (Input.GetKey("s") && updateJumpCount){
            updateJumpCount = false;
            jumpCount++;
        }

        // Check if the score should increase
        if (currentPlayerZ % 5 == 0 && currentPlayerZ != score)
        {
            score = currentPlayerZ;
            scoreText.text = score.ToString(); // Update the text display
        }
    }
}
