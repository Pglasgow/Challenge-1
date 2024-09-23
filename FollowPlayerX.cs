using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Challenge requirments
// Reposition it so it’s beside the plane - Done
// Make the camera follow the plane - Done
// Create a script that spins the plane’s propeller - Done


public class FollowPlayerX : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(11,1,5);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
