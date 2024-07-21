using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public GameObject Particle;

    void Start()
    {
        Particle.SetActive(false);

    }

    private void OnMouseDown()
    {
        Particle.SetActive(true);
    }


    private void OnMouseUp()
    {
        Particle.SetActive(false);
    }
}
