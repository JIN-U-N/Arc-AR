using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SetReactor : MonoBehaviour
{
    public Indicator indicator;
    public GameObject ReactorObj;
    public GameObject ShadowPlane;
    public AudioSource audioSource;

    private Vector3 ReactorUp= new Vector3(0,1f,0);
    private Quaternion ReactorRotation= Quaternion.Euler(0,110f,21f);

    public void Start()
    {
        indicator=FindObjectOfType<Indicator>();
    } 

    public void ToSet()
    {
        ShadowPlane=Instantiate(ShadowPlane,indicator.transform.position,indicator.transform.rotation);
        ReactorObj=Instantiate(ReactorObj,indicator.transform.position+ReactorUp,ReactorRotation);

        audioSource.Play();
        GameObject.Find("IndicatorManager").SetActive(false);
    }
}
