using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpeceShip : MonoBehaviour
{
  private Transform transform;

  public GameObject Bullet;
  public Transform Pos;
  public float speed;

  public float minX,maxX;
  public float minY,maxY;
  public void Start()
  {
    transform = GetComponent<Transform>();
  }

  public void Update()
  {
    if (Input.GetKey(KeyCode.D))
    {
      transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.A))
    {
      transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.W))
    {
      transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.S))
    {
      transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    transform.position = new Vector3(Mathf.Clamp(transform.position.x,minX,maxX),Mathf.Clamp(transform.position.y,minY,maxY),0);


    if (Input.GetKeyDown(KeyCode.Space))
    {
      Shoot();
    }
    
  }



  public void Shoot()
  {
    Instantiate(Bullet, Pos.position, Quaternion.identity);
  }


  public void OnCollisionEnter(Collision other)
  {
    if (other.transform.tag == "Enemy")
    {
      GameObject.Find("Manager").GetComponent<GameManger>().ShowMenu();
      Destroy(this.gameObject);
    }
  }
}
