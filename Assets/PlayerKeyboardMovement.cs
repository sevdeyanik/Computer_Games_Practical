/*
 * when the player presses either the "Left Arrow" or "A" key, the player character moves left across the platform, and when the "Right Arrow" or 
 * "D" key is pressed, the character moves right. The PlayerMovement script attached to the character controls this movement, with moveSpeed
 * determining the pace. Messages in the console indicate the script’s activation and the direction of movement for development purposes.
*/
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    void Start()
    {
        Debug.Log("PlayerMovement script has started.");
    }
    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            move.x -= moveSpeed * Time.deltaTime;
            Debug.Log("Moving Left");
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            move.x += moveSpeed * Time.deltaTime;
            Debug.Log("Moving Right");
        }

        transform.position += move;
    }
}
