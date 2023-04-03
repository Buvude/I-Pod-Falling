using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    public Rigidbody2D rb;

    [SerializeField] float playerSpeed;

    public Camera cam;
    private Vector2 dir;
    Touch touch;
    Vector3 touchPos;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        transform.Rotate(transform.forward * rotationSpeed);

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0;

            dir = touchPos - transform.position;
            //dir = dir.normalized;
            //Player.rb.velocity = (new Vector3(dir.x * playerSpeed, dir.y * playerSpeed, Player.transform.position.z));

            //Player.rb.AddForce(dir * playerSpeed, ForceMode2D.Force);
            float step = playerSpeed * Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, touchPos, step);

        }
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
