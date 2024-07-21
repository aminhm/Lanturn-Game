using UnityEngine;

public class CameraZoomScript : MonoBehaviour
{
    private Camera cameraObject;
    public float zoomSpeed = 5f;
    public float targetOrthographicSize = 4.5f;
    private float originalOrthographicSize;
    private bool zoomingIn = false;

    void Start()
    {
        cameraObject = GetComponent<Camera>();
        originalOrthographicSize = cameraObject.orthographicSize;
    }

    void Update()
    {
        if (zoomingIn)
        {
            cameraObject.orthographicSize = Mathf.Lerp(cameraObject.orthographicSize, targetOrthographicSize, Time.deltaTime * zoomSpeed);
        }
        else
        {
            cameraObject.orthographicSize = Mathf.Lerp(cameraObject.orthographicSize, originalOrthographicSize, Time.deltaTime * zoomSpeed);
        }

    }

    public void SetZoomTarget()
    {
        zoomingIn = true;
    }

    public void ResetPosition()
    {
        zoomingIn = false;
    }
}
