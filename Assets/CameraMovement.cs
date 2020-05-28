using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private float x;
    private float y;
    private Vector3 rotateValue;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            y = Input.GetAxis("Mouse X");
            x = Input.GetAxis("Mouse Y");
            rotateValue = new Vector3(x, y * -1, 0);
            transform.eulerAngles = transform.eulerAngles - rotateValue;
        }
    }
}

//      var heading = cameraTransform.rotation;
//      if(Input.GetKey(KeyCode.W)) // FORWARD
//      {
//          cameraTransform.position += new Vector3(heading.x, heading.y, heading.z);
//      }
//      if (Input.GetKey(KeyCode.S)) // BACKWARDS
//      {
//          cameraTransform.position -= new Vector3(heading.x, heading.y, heading.z);
//      }
//      if (Input.GetKey(KeyCode.A)) // LEFT ROTATION
//      {
//          cameraTransform.rota
//      }
//      if (Input.GetKey(KeyCode.D)) // RIGHT ROTATION
//      {

//      }
//      if (Input.GetKey(KeyCode.Q)) // UPWARD ROTATION
//      {

//      }
//      if (Input.GetKey(KeyCode.E)) // DOWNWARD ROTATION
//      {

//      }
