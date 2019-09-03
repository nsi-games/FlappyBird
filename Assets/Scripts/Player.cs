using System.Collections;
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
        // Cancel current Velocity
        rigid.velocity = Vector2.zero;
        // Add a force to rigidbody
        rigid.AddForce(new Vector2(0f, upForce), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        // If Space is pressed
        if (Input.GetButtonDown("Jump"))
        {
            // Player Flies Up!
            Flap();
        }
    }
}
