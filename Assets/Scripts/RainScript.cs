using UnityEngine;

public class RainScript : MonoBehaviour
{
    public GameObject Rain;
    public float yDeadZone = -6f;

    void Update()
    {
        if (Rain.transform.position.y <= yDeadZone)
        {
            Destroy(Rain);
        }
    }
}
