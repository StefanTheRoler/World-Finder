using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation = 0f;
    float YRotation = 0f;

    void Start()
    {
        //Locking the cursor to the middle of the screen and making it invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensY;

        //control rotation around x axis (Look up and down)
        xRotation -= mouseY;

        //we clamp the rotation so we cant Over-rotate (like in real life)
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //control rotation around y axis (Look up and down)
        YRotation += mouseX;

        //applying both rotations
        transform.rotation = Quaternion.Euler(xRotation, YRotation, 0);
        orientation.rotation = Quaternion.Euler(0, YRotation, 0);

    }
}
