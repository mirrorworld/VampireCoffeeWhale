﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {
    public float speed = 5.0f;
    public Vector2 vel;
    private Rigidbody2D rb2D;
    
    void Start() {
        rb2D = GetComponent<Rigidbody2D>();
        vel = Vector2.zero;
    }

    void Update() {
        vel = new Vector2(
            Input.GetAxis("Horizontal"), 
            Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
     {
         rb2D.MovePosition(rb2D.position + vel * speed * Time.fixedDeltaTime);
     }
}
