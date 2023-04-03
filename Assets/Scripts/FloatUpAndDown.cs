using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUpAndDown : MonoBehaviour
{
    Vector2 initPos;
    public float sinMagnitude;
    public float sinDistance = 1;
    public bool upDown;
    bool started;
    Rigidbody2D rb;
    private void Start()
    {
        initPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (!started)
        {
            transform.position = new Vector3(upDown ? transform.position.x : ((Mathf.Cos(Time.time * sinMagnitude) * sinDistance) + initPos.x),
            upDown ? ((Mathf.Sin(Time.time * sinMagnitude) * sinDistance) + initPos.y) : transform.position.y);
        } else
        {
            rb.simulated = true;
            transform.Rotate(transform.forward);
        }
        

        if (Input.touchCount >= 1)
        {
            started = true;
        }
    }
}
