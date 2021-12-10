using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text counter;
    int count  = 0;
    int score;
    public int scorecounter;
    public GameOverPanel gamO;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count % scorecounter == 0)
        {
            counter.text = "Score: " + score++.ToString();
      
        }
        else if(gamO.gameOver)
        {
                counter.text = "Score: dead";
        }

      count++;
        
    }
}
