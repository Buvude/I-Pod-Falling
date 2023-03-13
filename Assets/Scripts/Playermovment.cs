using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Playermovment : MonoBehaviour
{
    public GameObject Player;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount >= 1)
        {

            Vector2 v = cam.ScreenToWorldPoint(Input.touches[0].position);
            Player.transform.position = new Vector3(v.x, Player.transform.position.y);
            
            /* Ray2D ray = new Ray2D();
            Transform temp;
            ray = cam.ScreenToWorldPoint((Input.touches[0].position), cam);
            //temp.position=new Vector3(Player.transform.position.x, ))
            Player.transform.position = new Vector3(Player.transform.position.x, Input.touches[0].position.y, Player.transform.position.z);*/
        }
    }

    
}
