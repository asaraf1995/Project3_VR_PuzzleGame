﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject obj;
    public GameObject button;
    public GameObject wall;
    public GameObject teleportPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("wall")) {
            obj.transform.position = new Vector3(teleportPoint.transform.position.x - ((float) 2.98), obj.transform.position.y, 
                teleportPoint.transform.position.z);
            Console.WriteLine("something");
        }
    }

}

