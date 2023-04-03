using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathMovement : MonoBehaviour
{
    bool hitGround;

    private void Update()
    {
        if (!hitGround)
        {
            transform.Rotate(transform.forward);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitGround = true;
    }
}
