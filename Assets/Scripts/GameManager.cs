using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static bool playGame = true;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives;
        GameOver();
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + lives;
    }
    public void GameOver()
    {
        if (lives == 0)
        {
            gameOverText.gameObject.SetActive(true);
        }
    }
}
