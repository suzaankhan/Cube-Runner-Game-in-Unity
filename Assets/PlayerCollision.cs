using UnityEngine.UI;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public playerScript movement;
    public Text gameOverText;
    
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "obstacle"){

            movement.enabled = false;
            gameOverText.text = "GAME OVER";
        }
    }
}
