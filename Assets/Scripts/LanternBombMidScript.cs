using UnityEngine;

public class LanternBombMidScript : MonoBehaviour
{
    public GameObject LanternBomb_mid;
    public GameObject LanternBomb_full;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Particle")
        {
            Instantiate(LanternBomb_full, new Vector3(LanternBomb_mid.transform.position.x, LanternBomb_mid.transform.position.y,0), LanternBomb_mid.transform.rotation);
            Destroy(LanternBomb_mid);
        }
    }

}
