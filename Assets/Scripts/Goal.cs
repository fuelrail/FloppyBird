using UnityEngine;

public class Goal : MonoBehaviour
{
    public float opening;
    public float moveSpeed;

    bool point = false;

    void Start() {
        float randomY = Random.Range(-opening, opening);
        transform.position = new Vector3(transform.position.x, randomY, transform.position.z);
    }
    void Update() {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (point == false && transform.position.x <= 0) {
            ScoreManager.instance.AddPoint();
            point = true;
        }
    }
}
