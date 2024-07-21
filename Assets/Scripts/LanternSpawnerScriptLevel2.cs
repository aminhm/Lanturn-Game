using UnityEngine;

public class LanternSpawnerScriptLevel2 : MonoBehaviour
{
    public GameObject Lantern;
    public GameObject LanternYellow;
    public GameObject LanternGreen;
    public GameObject LanternYellowBomb;
    public GameObject LanternGreenBomb;
    public GameObject LanternBomb;
    public float spawnRate = 1f;
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
        var randomLantern = Random.Range(2, 14);
        Instantiate(
            randomLantern < 8 ? Lantern
            : randomLantern < 10 ? LanternYellow
            : randomLantern < 12 ? LanternGreen
            : randomLantern < 13 ? LanternGreenBomb
            : randomLantern < 14 ? LanternYellowBomb
            : LanternBomb,
            new Vector3(Random.Range(lowestXpoint,highestXpoint),transform.position.y,0), transform.rotation);
        Lantern.GetComponent<Rigidbody2D>().gravityScale = -0.02f;
    }
}
