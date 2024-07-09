using UnityEngine;
using UnityEngine.SceneManagement; // Include this to use SceneManager

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; // Creating a reference to the player movement script to disable movement after collision
    public float fallThreshold = -10f; // Threshold for falling off the map

    void Update()
    {
        // Check if the player has fallen off the map
        if (transform.position.y < fallThreshold)
        {
            ReplayScene();
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        // When there is a collision
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Grouping all obstacles with tag "Obstacle"
            movement.enabled = false; // Stop movement if the object collides with an obstacle grouped with name tag

            // Reload the Level1 scene to replay
            Invoke("ReplayScene", 2f); // Adds a 2 second delay before reloading the scene
        }
    }

    void ReplayScene()
    {
        SceneManager.LoadScene("Level1"); // Reload the Level1 scene
    }
}
