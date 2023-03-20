using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*print("trigger entered by" + collision.ToString());*/
        if (collision.gameObject.GetComponent<Playermovment>() == null)
        {
            /*print("triggerd by " + collision.ToString());*/
            SceneManager.LoadScene(0);
        }
    }
}
