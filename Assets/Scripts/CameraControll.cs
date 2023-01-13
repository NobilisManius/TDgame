using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public float panSpeed = 30f;

    public float zoomSpeed = 150f;

    public int panBorderThickness = 20;

    public float minY = 10f;
    public float maxY = 80f;
    private void Update()
    {
        if(Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if(Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        if(Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if(Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        if (Input.mouseScrollDelta.y > 0 & transform.position.y > minY)
        {
            transform.Translate(Vector3.forward * zoomSpeed * Time.deltaTime, Space.Self);
        }
        
        if (Input.mouseScrollDelta.y < 0 & transform.position.y < maxY)
        {
            transform.Translate(Vector3.back * zoomSpeed * Time.deltaTime, Space.Self);
        }

    }
}
