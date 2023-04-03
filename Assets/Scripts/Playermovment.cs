using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Playermovment : MonoBehaviour
{
    public PlayerCollision Player;
    [SerializeField]float playerSpeed;
    
    public Camera cam;
    private Vector2 dir;
    Touch touch;
    Vector3 touchPos;

    private void Start()
    {
        Player = FindObjectOfType<PlayerCollision>();
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0;

            dir = touchPos - Player.transform.position;
            //dir = dir.normalized;
            //Player.rb.velocity = (new Vector3(dir.x * playerSpeed, dir.y * playerSpeed, Player.transform.position.z));

            //Player.rb.AddForce(dir * playerSpeed, ForceMode2D.Force);
            float step = playerSpeed * Time.deltaTime;
            Player.transform.position = Vector3.Lerp(Player.transform.position, touchPos, step);

        }
                
    }
    private void FixedUpdate()
    {
        if (Player.transform.position.y > 4.5f)
        {
            Player.transform.position = new Vector3(Player.transform.position.x, 4, Player.transform.position.z);
        }
        if (Player.transform.position.x < -3.5f)
        {
            Player.transform.position = new Vector3(-3.5f, Player.transform.position.y, Player.transform.position.z);
        }
        if (Player.transform.position.x > 3.5f)
        {
            Player.transform.position = new Vector3(3.5f, Player.transform.position.y, Player.transform.position.z);
        }
    }



}



