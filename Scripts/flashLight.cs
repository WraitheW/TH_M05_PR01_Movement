using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction;

public class flashLight : MonoBehaviour
{
    public GameObject spotLight;
    bool flashlightOn = false;

    void Start()
    {
        spotLight.SetActive(false);
    }

    public void onAndOff()
    {
        if (flashlightOn)
        {
            flashlightOn = false;
            spotLight.SetActive(false);
        }
        
        if (!flashlightOn)
        {
            flashlightOn = true;
            spotLight.SetActive(true);
        }
    }
}
