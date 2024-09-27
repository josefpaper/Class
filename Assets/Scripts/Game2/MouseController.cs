using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float mouseSensitivity = 1000f;

    public Transform Player;

    public float xRotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        

        xRotation -= MouseY;

        xRotation = Mathf.Clamp(xRotation, -80, 50);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        Player.Rotate(Vector3.up * MouseX);
    }
}
