using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            //do something when Obstacle hit
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
