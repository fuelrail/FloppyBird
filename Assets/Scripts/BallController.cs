using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float velocity;
    private Rigidbody2D rb;

    public GameOverScreen GameOverScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = Vector2.up * velocity;
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
        GameOverScreen.Setup(ScoreManager.instance.GetScore());
        Time.timeScale = 0;
    }
}
