using UnityEngine;

public class ShowObjectWhenPlayerReachesZ : MonoBehaviour
{
    public GameObject player; // Drag and drop the player GameObject in the Inspector
    public float triggerZPosition = 10f; // The Z position to trigger the object display

    private void Start()
    {
        // Ensure this object is initially hidden
        gameObject.SetActive(false);
        Debug.Log("Script has statrted");
    }

    private void Update()
    {
        if (player != null)
        {
        Debug.Log("Player Z Position: " + player.transform.position.z);
        if (player.transform.position.z >= triggerZPosition)
        {
            Debug.Log("Trigger reached! Showing object.");
            gameObject.SetActive(true);
            this.enabled = false; // Disable the script if needed
        }
        }
    else
    {
        Debug.LogWarning("Player reference is missing!");
    }
    }
}
