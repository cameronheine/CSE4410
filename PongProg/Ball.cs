using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    private float x;
    private float y;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Launch();
        
    }

    private void Launch()
    {
        if(Random.Range(0, 2) == 0)
        {
            x = -1;
        }
        else
        {
            x = 1;
        }
        if (Random.Range(0, 2) == 0)
        {
            y = -1;
        }
        else
        {
            y = 1;
        }
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero; 
        transform.position = startPosition;
        Launch();
    }
}