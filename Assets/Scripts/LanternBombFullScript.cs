using System.Collections;
using UnityEngine;

public class LanternBombFullScript : MonoBehaviour
{
    public GameObject LanternBomb_full;
    public Sprite lanternMidSprite;
    public Sprite lanternYellowMidSprite;
    public Sprite lanternGreenMidSprite;
    public GameObject explodeAnimation;
    private CameraZoomScript cameraZoom;
    public Animator animator;
    void Awake()
    {
        animator.enabled = false;
        cameraZoom = Camera.main.GetComponent<CameraZoomScript>();
    }
    void Start()
    {
        animator.enabled = true;
        cameraZoom.SetZoomTarget();
        StartCoroutine(ExplodeTime(0.8f));
    }

    IEnumerator ExplodeTime(float time)
    {
        yield return new WaitForSeconds(time);

        var lanterns = GameObject.FindGameObjectsWithTag("LanternTag");

        for (int i=0; i < lanterns.Length; i++)
        {
            if (lanterns[i].GetComponent<SpriteRenderer>().sprite.name == "Lantern-full")
            {
                lanterns[i].GetComponent<SpriteRenderer>().sprite = lanternMidSprite;
            }
            else if (lanterns[i].GetComponent<SpriteRenderer>().sprite.name == "Lantern-Yellow-full")
            {
                lanterns[i].GetComponent<SpriteRenderer>().sprite = lanternYellowMidSprite;
            }
            else if (lanterns[i].GetComponent<SpriteRenderer>().sprite.name == "Lantern-Green-full")
            {
                lanterns[i].GetComponent<SpriteRenderer>().sprite = lanternGreenMidSprite;
            }
            lanterns[i].GetComponent<Animator>().Play("TurnOff");
            lanterns[i].GetComponent<Rigidbody2D>().gravityScale = 1;
        }

        Instantiate(explodeAnimation, new Vector3(LanternBomb_full.transform.position.x, LanternBomb_full.transform.position.y, 0), LanternBomb_full.transform.rotation);

        cameraZoom.ResetPosition();

        Destroy(LanternBomb_full);
    }

}
