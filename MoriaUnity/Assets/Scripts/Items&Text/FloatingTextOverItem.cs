﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextOverItem : MonoBehaviour
{
    float rotateSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeed, 0, 0);
    }
}
