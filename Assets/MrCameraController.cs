using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrCameraController : MonoBehaviour {
    public Camera camera;
    public GameObject camera_tracker;       //Public variable to store a reference to the player game object

    public float tracker_x = 0;
    public float tracker_y = 0;
    public float tracker_z = 0;

    public float rotation_x = 0;
    public float rotation_y = 0;
    public float rotation_z = 0;
    public float FOV = 100;


    private Vector3 offset;         //Private variable to store the offset distance between the player and camera


    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        //  offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.A))
        {
            tracker_x += 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            tracker_x -= 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            tracker_y += 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            tracker_y -= 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            tracker_z += 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            tracker_z -= 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            FOV -= 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            FOV += 0.1f;
        }
        // Set the position of the camera's transform to be the same as the target obj, but offset by the calculated offset distance.

        offset = new Vector3(tracker_x, tracker_y, tracker_x);
        transform.position = camera_tracker.transform.position + offset;

        transform.rotation = camera_tracker.transform.rotation * Quaternion.Euler(rotation_x, rotation_y, rotation_z); // this adds a 90 degrees Y rotation;

        camera.fieldOfView = FOV;
    }

}
