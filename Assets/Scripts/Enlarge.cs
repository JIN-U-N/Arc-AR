using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Enlarge : MonoBehaviour
{
    public SetArc setArc;
    private Vector3 ArcScale;
    private Vector3 TargetScale;
    public AudioSource audioSource;
    
    private float UpSpeed=0.4f;
    private bool IsScale=false;

    void Start()
    {
        setArc=FindObjectOfType<SetArc>();
        ArcScale=setArc.ArcObj.transform.localScale;
        TargetScale=ArcScale*150f;

    }

    void Update()
    {
        if(IsScale==true)
        {
            setArc.ArcObj.transform.localScale=Vector3.Lerp(setArc.ArcObj.transform.localScale, TargetScale, UpSpeed * Time.deltaTime);
        }
    }

    public void Up()
    {   
        IsScale=true;
        setArc.ParticleBox.SetActive(false);
        setArc.ShadowPlane.SetActive(false);
        audioSource.Play();
    }
    
}
