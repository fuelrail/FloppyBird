using UnityEngine;

public class SpawnAndMoveObjects : MonoBehaviour
{
    public GameObject objectPrefab;
    public float rightOffset;
    private Vector3 spawnPoint;
    public float spacing;

    void Start()
    {
        float rightWorldPoint = Camera.main.ViewportToWorldPoint(new Vector3(1, 0.5f, 0)).x + 0.5f + rightOffset;
        spawnPoint = transform.localPosition;
        spawnPoint.x = rightWorldPoint;

        SpawnPipes();
    }

    void Update()
    {
        Transform firstObject = transform.GetChild(transform.childCount - 1);
        if (firstObject.position.x + spacing < spawnPoint.x) {
            SpawnPipes();
        }

        Transform lastObject = transform.GetChild(0);
        Vector3 lastViewportPosition = Camera.main.WorldToViewportPoint(lastObject.position);
        if (lastViewportPosition.x + 0.5f < 0)
        {
            Destroy(lastObject.gameObject);
        }
    }

    void SpawnPipes() {
        GameObject obj = Instantiate(objectPrefab, transform);
        obj.transform.localPosition = spawnPoint;
    }
}
