using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class test : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;
    public void Update()
    {
        Vector3 dir = (-this.transform.position + target.position).normalized;
        this.transform.Translate(dir * Time.deltaTime * speed);
        
        Debug.DrawLine(this.transform.position , dir,Color.black);
    }
}