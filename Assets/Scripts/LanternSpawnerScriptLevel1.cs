using UnityEngine;

public class LanternSpawnerScriptLevel1 : MonoBehaviour
{
    public GameObject Lantern;
    public GameObject LanternYellow;
    public float spawnRate = 1.5f;
    public float timer = 0;
    public float widthOffset = 2.6f;
    public float xTransformPosition = -0.85f;

    void Start()
    {
        spawnLantern();
    }

    void Update()
    {
        if(timer < spawnRate)
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
        var randomLantern = Random.Range(2, 10);
        Instantiate(
            randomLantern < 7 ? LanternYellow
            : Lantern,
            new Vector3(Random.Range(lowestXpoint,highestXpoint),transform.position.y,0), transform.rotation);
        Lantern.GetComponent<Rigidbody2D>().gravityScale = -0.02f;
    }
}
