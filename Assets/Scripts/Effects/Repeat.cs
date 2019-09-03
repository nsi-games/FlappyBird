using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Repeat : MonoBehaviour
{
    public float padding = 0.01f; // Room for Error

    private BoxCollider2D box; // Reference to BoxCollider
    private float width; // Width of Object based on BoxCollider

    // Start is called before the first frame update
    void Start()
    {
        // Get the BoxCollider
        box = GetComponent<BoxCollider2D>();
        // Store size of Collider along Horizontal Axis
        width = box.size.x * transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        // Get position from transform
        Vector3 position = transform.position;
        // Is the position outside of the camera?
        if(position.x < -width)
        {
            // Repeat object!
            Loop();
        }
    }

    void Loop()
    {
        float offset = width - padding;
        transform.position += new Vector3(offset * 2, 0);
    }
}
