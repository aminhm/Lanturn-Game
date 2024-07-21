using UnityEngine;

public class RainSpawner : MonoBehaviour
{
    public GameObject Rain;
    public float spawnRate = 0.0001f;
    public float timer = 0;
    public float widthOffset = 4f;
    public float xTransformPosition = -0.85f;

    void Start()
    {
        spawnRain();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnRain();
            timer = 0;
        }

    }
    void spawnRain()
    {
        float highestXpoint = xTransformPosition + widthOffset;
        float lowestXpoint = xTransformPosition - widthOffset;

        Instantiate(Rain, new Vector3(Random.Range(lowestXpoint, highestXpoint), transform.position.y, 0), transform.rotation);
    }
}
