using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Rotate: MonoBehaviour
{
    Transform transform;
    public float RotateSpeed= 30f;

    void Start()
    {
        transform=this.GetComponent<Transform>();
    }

    void Update()
    {
        transform.Rotate(RotateSpeed*Time.deltaTime,RotateSpeed*Time.deltaTime,0);
    }
    
}
