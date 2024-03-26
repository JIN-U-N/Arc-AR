using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public GameObject soundManager;
    public AudioSource audioSource;

    void Awake()
    {
        audioSource=soundManager.GetComponent<AudioSource>();
        if(audioSource.isPlaying)
        {
            return;
        }
        else
        {
            audioSource.Play();
            DontDestroyOnLoad(audioSource);
        }
    }
}
