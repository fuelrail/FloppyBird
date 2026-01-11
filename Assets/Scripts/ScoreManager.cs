using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    
    public TMP_Text scoreText;
    int score = 0;

    private void Awake() {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString();
    }

    public void AddPoint() {
        score += 1;
        scoreText.text = score.ToString();
    }

    public int GetScore() {
        return score;
    }
}
