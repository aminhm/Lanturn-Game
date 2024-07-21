using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBarScript : MonoBehaviour
{
    public Scrollbar scrollbar;
    public GameObject EndScene;
    void Update()
    {
        if (scrollbar.size >= 1)
        {
            EndScene.SetActive(true);
        } 
    }
}
