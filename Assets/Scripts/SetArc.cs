using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SetArc: MonoBehaviour
{

    public Indicator indicator;
    public GameObject ArcObj;
    public GameObject ParticleBox;
    public GameObject ShadowPlane;

    public AudioSource audioSource;

    private Vector3 ArcUp= new Vector3(0,1.3f,0);

    public void Start()
    {
        indicator=FindObjectOfType<Indicator>();
    } 

    public void ToSet()
    {
        ShadowPlane=Instantiate(ShadowPlane,indicator.transform.position,indicator.transform.rotation);
        ParticleBox=Instantiate(ParticleBox,indicator.transform.position+ArcUp,indicator.transform.rotation);
        ArcObj=Instantiate(ArcObj,indicator.transform.position+ArcUp,indicator.transform.rotation);

        audioSource.Play();
        GameObject.Find("IndicatorManager").SetActive(false);
    }
    
}
