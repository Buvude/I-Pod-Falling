using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayBestScore : MonoBehaviour
{
    [SerializeField] Text text1;
    [SerializeField] Text text2;
    //[SerializeField] int score;
    // Start is called before the first frame update
    void Start()
    {
        text1.text = "Best: " + PlayerPrefs.GetInt("BestScore");
        text2.text = "Best: " + PlayerPrefs.GetInt("BestScore");
    }

}
