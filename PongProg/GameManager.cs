using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player1")]
    public GameObject Player1Paddle;
    public GameObject Player1Goal;

    [Header("Player2")]
    public GameObject Player2Paddle;
    public GameObject Player2Goal;

    [Header("ScoreBox")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int player1Score;
    private int player2Score;

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        Player1Paddle.GetComponent<Paddle>().Reset(); 
        Player2Paddle.GetComponent<Paddle>().Reset();
    }

    public void Player1Scored()
    {
        player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        ResetPosition();
    }
    public void Player2Scored()
    {
        player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        ResetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (player1Score >= 5)
        {
            Player1Text.GetComponent<TextMeshProUGUI>().text = "Win";
            Player2Text.GetComponent<TextMeshProUGUI>().text = "Lose";
        }
        else if (player2Score >= 5)
        {
            Player1Text.GetComponent<TextMeshProUGUI>().text = "Lose";
            Player2Text.GetComponent<TextMeshProUGUI>().text = "Win";
        }

        if (Input.GetKey("escape"))
        {
           Application.Quit();
        }
        
    } 
}
