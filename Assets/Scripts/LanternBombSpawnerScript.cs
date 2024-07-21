using UnityEngine;

public class LanternBombSpawnerScript : MonoBehaviour
{
    public GameObject Lantern;
    public float spawnRate = 3;
    public float timer = 0;
    public float widthOffset = 2.6f;
    public float xTransformPosition = -0.85f;

    void Start()
    {
        spawnLantern();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnLantern();
            timer = 0;
        }

    }
    void spawnLantern()
    {
        float highestXpoint = xTransformPosition + widthOffset;
        float lowestXpoint = xTransformPosition - widthOffset;

        Instantiate(Lantern, new Vector3(Random.Range(lowestXpoint, highestXpoint), transform.position.y, 0), transform.rotation);
    }
}
