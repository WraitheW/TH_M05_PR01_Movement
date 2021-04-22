using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float CupScore = 0;
    public float engineCount = 4;
    //public Text score;
    public TMP_Text scoreText;
    public TMP_Text engineText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + CupScore.ToString();
        engineText.text = "Engines left: " + engineCount.ToString();
    }

    public void AddScore()
    {
        CupScore++;
    }

    public void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
