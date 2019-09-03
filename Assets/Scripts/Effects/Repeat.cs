using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Repeat : MonoBehaviour
{
    public float padding = 0.01f;

    private BoxCollider2D box; // Reference to BoxCollider Component
    private float width; // Width of the Sprite

    // Start is called before the first frame update
    void Start()
    {
        // Get BoxCollider2D Component
        box = GetComponent<BoxCollider2D>();
        // Store size of collider along Horizontal axis
        width = box.size.x * transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        // Get position
        Vector3 position = transform.position;
        // Is the position on the X outside the camera?
        if(position.x < -width)
        {
            // Repeat the object
            Loop();
        }
    }

    void Loop()
    {
        // Get offset position outside the screen
        float offset = width - padding;
        // Move the position back 2 times the scale
        transform.position += new Vector3(offset * 2, 0);
    }
}
