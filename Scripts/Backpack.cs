using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    public GameObject flashlight;

    public void Flashlight()
    {
        if (flashlight.active == true)
        {
            flashlight.SetActive(false);
        }

        if (flashlight.active == false)
        {
            flashlight.SetActive(true);
        }
    }
}
