﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float upForce = 6f;

    private Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    public void Flap()
    {
        rigid.velocity = Vector3.zero;
        rigid.AddForce(new Vector2(0f, upForce), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Flap();
        }
    }

    // 2D Trigger Detection for Player
    void OnTriggerEnter2D(Collider2D other)
    {
        // If Player collides with Column
        if(other.tag == "Column")
        {
            // Add a Score through the GameManager
            GameManager.Instance.AddScore(1);
        }
    }

}