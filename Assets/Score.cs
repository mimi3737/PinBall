using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    private int score = 0; 
    void Start()
    {
        
        score = 0;
        SetScore();


    }


    void OnCollisionEnter(Collision other)
    {

        string thisTag = other.gameObject.tag;
           
        if (thisTag == "SmallStarTag")
        {
            score += 300;
        }
        else if (thisTag == "LargeStarTag")
        {
            score += 100;
        }
        else if (thisTag == "SmallCloudTag")
        {
            score += 100;
        }
        else if (thisTag == "LargeCloudTag")
        {
            score += 150;
        }
        SetScore();
    }

    void SetScore()
    {
        ScoreText.text = string.Format("Score:{0}", score);
  
    }
    void Update()
    {

    }
}