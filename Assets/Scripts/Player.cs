using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float upForce = 6f;
    public float forward = 1f;

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

        // Rotate Bird
        Vector3 vel = rigid.velocity;
        float angle = Mathf.Atan2(vel.y, forward) * Mathf.Rad2Deg;
        angle = Mathf.Clamp(angle, -45f, 45f);
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    // If colliding with something
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Game is over!
        GameManager.Instance.GameOver();
    }

    // Event for detecting Trigger Collisons
    private void OnTriggerEnter2D(Collider2D col)
    {
        // If colliding with a Column
        if(col.tag == "Column")
        {
            // Add 1 to Score
            GameManager.Instance.AddScore(1);
        }
    }
}
