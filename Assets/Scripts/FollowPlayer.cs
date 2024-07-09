using UnityEngine;

public class FollowPlayer : MonoBehaviour
//can also use parentling but will have trouble when the player is colliding with an obj
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; //small t for transform refers to the current obj ie the camera

    }
}
