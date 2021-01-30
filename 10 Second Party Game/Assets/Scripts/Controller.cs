﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 3.0f;

    public int flags { get { return currentFlags; }}
    int currentFlags;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}

        if (Input.GetKey(KeyCode.A))
        {
			transform.position += Vector3.left * speed * Time.deltaTime;
		}

        if (Input.GetKey(KeyCode.S))
        {
			transform.position += Vector3.down * speed * Time.deltaTime;
		}

        if (Input.GetKey(KeyCode.D))
        {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
        
    }

    public void ChangeFlags (int amount)
    {
        currentFlags = Mathf.Clamp(currentFlags + amount, 0, 5);
    }
}
