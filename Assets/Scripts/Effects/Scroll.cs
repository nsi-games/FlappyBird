using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Scroll : MonoBehaviour
{
    public float scrollSpeed = -5f;

    private Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody2D Component
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Start the object moving on Velocity
        rigid.velocity = new Vector2(scrollSpeed * GameManager.Instance.globalSpeed, 0f);
    }
}
