using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject Ball;
    private GameObject UserScore;
    private GameObject AIScore;

    private int UserScoreVal;
    private int AIScoreVal;

    public void UserScored()
    {
        AIScoreVal++;
        AIScore.GetComponent<TextMeshProUGUI>().text = AIScoreVal.ToString();
        Ball.GetComponent<Ball>().Reset();
    }
    public void AIScored()
    {
        UserScoreVal++;
        UserScore.GetComponent<TextMeshProUGUI>().text = UserScoreVal.ToString();
        Ball.GetComponent<Ball>().Reset();
    }

    void Start()
    {
        Ball = GameObject.Find("Ball");
        UserScore = GameObject.Find("UserScore");
        AIScore = GameObject.Find("AIScore");
    }

    private void Update()
    {
        if( Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
