using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Challenge requirments
// Make the plane go forward
// Slow the plane down to a manageable speed
// Make the plane tilt only if the user presses the up/down arrows
// Reposition it so it’s beside the plane
// Make the camera follow the plane
// Create a script that spins the plane’s propeller


public class PlayerControllerX : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed;
    public float verticalInput;

    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        forwardInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
