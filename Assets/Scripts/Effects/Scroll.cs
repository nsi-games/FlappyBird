using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Scroll : MonoBehaviour
{
    public float scrollSpeed = -10f; // How fast the object moves across screen

    private Rigidbody2D rigid; // Reference to Rigidbody component

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(scrollSpeed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
