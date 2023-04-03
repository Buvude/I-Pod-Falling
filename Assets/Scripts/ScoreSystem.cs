using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] Text text1;
    [SerializeField] Text text2;
    [SerializeField] int score;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("AddScore"))
        {
            score++;
            if (score > PlayerPrefs.GetInt("BestScore"))
            {
                PlayerPrefs.SetInt("BestScore", score);
            }
            text1.text = "Score: " + score.ToString();
            text2.text = "Score: " + score.ToString();
            Destroy(other.gameObject);        
        }
    }
}
