using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI text;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        //Create GameManager instance if there isn't one yet
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int scoreIncrement)
    {
        score += scoreIncrement;
        text.text = "Score: " + score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
