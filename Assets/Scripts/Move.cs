using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
   public Rigidbody rb;

   public Vector3 Dir;

   public float Force = 1000f;
   public float jumpForce = 200;
   private void Start()
   {
      rb = GetComponent<Rigidbody>();
      
      
   }

   private void Update()
   {
     
   }

   private void FixedUpdate()
   {
      if (Input.GetKey(KeyCode.W))
      {
         rb.AddTorque(Vector3.right * Force);
      }
      if (Input.GetKey(KeyCode.S))
      {
         rb.AddTorque(Vector3.left * Force);
      }
      if (Input.GetKey(KeyCode.D))
      {
         rb.AddTorque(Vector3.back * Force);
      }
      if (Input.GetKey(KeyCode.A))
      {
         rb.AddTorque(Vector3.forward * Force);
      }
      
      if (Input.GetKey(KeyCode.Space))
      {
         rb.AddForce(Vector3.up * Force);
      }
   }
}
