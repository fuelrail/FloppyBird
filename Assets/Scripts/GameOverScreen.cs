using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public TMP_Text scoreText;

    public void Setup(int score) {
        gameObject.SetActive(true);
        scoreText.text = score.ToString() + " POINTS";
    }

    public void RestartButton() {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
}
