﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantVelocity : MonoBehaviour
{
    public float xspeed;
        public float zspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3 (xspeed, 0, zspeed);
    }
}
