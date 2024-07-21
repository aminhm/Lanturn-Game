using UnityEngine;

public class explodeAnimationScript : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2f);
    }
}
