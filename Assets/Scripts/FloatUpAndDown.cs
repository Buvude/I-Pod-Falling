using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUpAndDown : MonoBehaviour
{
    Vector2 initPos;
    Touch touch;
    public float sinMagnitude;
    public float sinDistance = 1;
    public bool upDown;
    bool started;
    [SerializeField] float speed;
    Rigidbody2D rb;
    private void Start()
    {
        initPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.touchCount > 0) 
        {
            touch = Input.GetTouch(0);
        }
        
        if (!started)
        {
            transform.position = new Vector3(upDown ? transform.position.x : ((Mathf.Cos(Time.time * sinMagnitude) * sinDistance) + initPos.x),
            upDown ? ((Mathf.Sin(Time.time * sinMagnitude) * sinDistance) + initPos.y) : transform.position.y);
        } else
        {
            rb.simulated = true;
            transform.Rotate(transform.forward * speed * Time.deltaTime);
        }


        if (Input.touchCount >= 1)
        {
            if (touch.phase == TouchPhase.Began)
            {
                started = true;
            }
        }
    }
}
