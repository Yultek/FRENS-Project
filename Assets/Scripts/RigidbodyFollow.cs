using UnityEngine;

public class RigidbodyFollow : MonoBehaviour
{
    public Transform target;
    public Rigidbody rb;
    public float thrust = 1f;
    public float revthrust = -1f;
    public Transform LookAttarget;
    public Transform UpVector;
    public float rotationSpeed = 5f;
    public Transform OziTransform;
    public float MaxDist = 10f;
    public float MinDist = 5f;

    public float TargetDist = 7f; // Desired target distance in the middle

    private bool isFloating = false; // Flag to indicate if the object is floating



    public bool enableOnStart = true; // Flag to enable the script at start

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        //LookAttarget = GameObject.FindWithTag("LookAtTarget").transform; 
        //UpVector = GameObject.FindWithTag("UpVector").transform;
    

        if (enableOnStart)
        {
            enabled = true; // Enable the script
        }
    }

    private void FixedUpdate()
{
    float distance = Vector3.Distance(OziTransform.position, LookAttarget.position);

    if (distance >= MinDist && distance <= MaxDist)
    {
        OziTransform.rotation = Quaternion.Slerp(OziTransform.rotation,
            Quaternion.LookRotation(LookAttarget.position - OziTransform.position), rotationSpeed * Time.deltaTime);

        // Check if the object is within the desired distance range
        if (distance > MinDist && distance < MaxDist)
        {
            Vector3 forwardForce = transform.forward * thrust;
            forwardForce.y = 0f; // Remove vertical component of the force
            rb.AddForce(forwardForce);
        }
        else
        {
            // Object is within the range, stop adding forces
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
    else if (distance < MinDist)
    {
        OziTransform.rotation = Quaternion.Slerp(OziTransform.rotation,
            Quaternion.LookRotation(OziTransform.position - LookAttarget.position), rotationSpeed * Time.deltaTime);

        Vector3 reverseForce = transform.forward * revthrust;
        reverseForce.y = 0f; // Remove vertical component of the force
        rb.AddForce(reverseForce);
    }
    else if (distance > MaxDist)
    {
        OziTransform.rotation = Quaternion.Slerp(OziTransform.rotation,
            Quaternion.LookRotation(LookAttarget.position - OziTransform.position), rotationSpeed * Time.deltaTime);

        Vector3 forwardForce = transform.forward * thrust;
        forwardForce.y = 0f; // Remove vertical component of the force
        rb.AddForce(forwardForce);
    }
}


}
