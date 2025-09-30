using UnityEngine;

// Controls player movement and rotation.
public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f; // Set player's movement speed.
    public float rotationSpeed = 359.0f; // Set player's rotation speed.

    private Rigidbody rb; // Reference to player's Rigidbody.

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Access player's Rigidbody.
    }

    // Update is called once per frame
    void Update()
    {
    	speed =+ speed +0.01f;
    }


    // Handle physics-based movement and rotation.
    private void FixedUpdate()
    {
        // Move player based on vertical input.
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

	if (Input.GetKey(KeyCode.Space))
	{
        Vector3 moement = transform.up * 10 * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moement);
	}
        // Rotate player based on horizontal input.
        float turn = Input.GetAxis("Horizontal") * 10 * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}