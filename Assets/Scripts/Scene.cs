using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;
using System;

public class Scene : MonoBehaviour
{
    public void GotoReactor()
    {
        SceneManager.LoadScene("Reactor",LoadSceneMode.Single);
    }

    public void GotoArc()
    {
        SceneManager.LoadScene("Arc",LoadSceneMode.Single);
    }
}
