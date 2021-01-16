using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixCamera : MonoBehaviour
{
    // change these numbers to your preferred apect ratio (9:16 in this case)
    const int resolutionX = 9;
    const int resolutionY = 16;

    void Start()
    {
        Camera cam = GetComponent<Camera>();
        float aspectRatio = Screen.width / Screen.height;

        cam.aspect = aspectRatio;
        


    }
}