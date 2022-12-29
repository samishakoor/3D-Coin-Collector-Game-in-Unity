using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);           //the main camera will purely focus on the target gameobject (in other words,the position,rotation etc of camera will inline to where the gameobject goes on screen)
    }
}
