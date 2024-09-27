using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform _transform;

    public float speed = 10f;

    public float y;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _transform.Translate(Vector3.up * speed * Time.deltaTime);


        if (_transform.position.y >= y)
        {
            Destroy(this.gameObject);
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Enemy")
        {
            GameObject.Find("Manager").GetComponent<GameManger>().AddScore();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
