using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Vector3 offset;
    private Transform playerTransform;

    public float ZoomSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        
        Camera.main.fieldOfView += scroll*ZoomSpeed;
        
        Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 25, 70);
    }
}
