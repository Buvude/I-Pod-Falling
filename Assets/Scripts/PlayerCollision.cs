using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    public Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        transform.Rotate(transform.forward * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Test");
        if (collision.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
