using UnityEngine;

public class MaintainYHeight : MonoBehaviour
{
    public Transform player;
    public float heightOffset = 0f;
    public float forceStrength = 10f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (player != null)
        {
            // Calculate the target height with the player's height and offset
            float targetHeight = player.position.y + heightOffset;

            // Calculate the target position with the desired height
            Vector3 targetPosition = new Vector3(transform.position.x, targetHeight, transform.position.z);

            // Calculate the force needed to maintain the height
            Vector3 force = forceStrength * (targetPosition - transform.position);

            // Apply the force to the Rigidbody
            rb.AddForce(force);
        }
    }
}
