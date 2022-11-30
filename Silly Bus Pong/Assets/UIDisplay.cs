using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDisplay : MonoBehaviour
{

    [Header("Player 1 Score")]
    [SerializeField] TextMeshProUGUI scoreTextPlayer1;

    [Header("Player 2 Score")]
    [SerializeField] TextMeshProUGUI scoreTextPlayer2;

    ScoreManager scoreManager;

    void Awake()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            scoreTextPlayer1.text = scoreManager.GetPlayer1Score().ToString();
            scoreTextPlayer2.text = scoreManager.GetPlayer2Score().ToString();
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message);
            throw;
        }
    }
}
