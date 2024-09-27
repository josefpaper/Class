using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController CC;

    public float speed = 20f;

    public float Gravity = -9.8f;

    public Vector3 velocity;

    public LayerMask GroundLayer;
    public Transform GroundCheckTransform;
    public bool IsGrounded;

    public float R = 0.5f;

    public float jumpH;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = Physics.CheckSphere(GroundCheckTransform.position, R, GroundLayer);
        
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        CC.Move(Vertical * Time.deltaTime * speed * transform.forward);
        CC.Move(Horizontal * Time.deltaTime * speed * transform.right);

        ////////////
        velocity.y += Gravity * Time.deltaTime;

        if (IsGrounded== true && velocity.y <0)
        {
            velocity.y = -2;
        }
        
        CC.Move(velocity * Time.deltaTime);
        
        ///jump

        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = jumpH;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(GroundCheckTransform.position, R);
    }
}
