using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public bool gameStart = false;
    [SerializeField]
    private int score;
    [SerializeField]
    private Text scoretext;
    
    void Start()
    {
        InvokeRepeating("ScoreUpdate", 1.0f, 1.0f);
    }

    void Update()
    {
        //ScoreUpdate();
    }

    private void ScoreUpdate() 
    {
        if (gameStart == true) 
        {
            score++;
            scoretext.text = "" + score;
        }
        
    }
}

