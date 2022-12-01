using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScores : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI player1Score;
    public TextMeshProUGUI player2Score;

    void Start()
    {
        player1Score.text = PlayerPrefs.GetInt("Player 1 Score", 1).ToString();
        player2Score.text = PlayerPrefs.GetInt("Player 2 Score", 1).ToString();
    }
}
