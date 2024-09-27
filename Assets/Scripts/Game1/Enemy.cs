using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
   private Transform _transform;
   public float speed;
   private void Start()
   {
      _transform = GetComponent<Transform>();

      speed = Random.Range(5.0f, 6.0f);
   }

   private void Update()
   {
      _transform.Translate(Vector3.down * speed * Time.deltaTime);

      if (_transform.position.y < -5f)
      {
         Destroy(this.gameObject);
      }
   }
}
