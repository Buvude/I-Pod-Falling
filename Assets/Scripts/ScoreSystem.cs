using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] Text text1;
    [SerializeField] Text text2;
    [SerializeField] int score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("AddScore"))
        {
            score++;
            text1.text = "Score: " + score.ToString();
            text2.text = "Score: " + score.ToString();
            Destroy(other.gameObject);        
        }
    }
}
