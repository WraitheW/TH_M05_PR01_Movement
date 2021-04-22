using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerryCan : MonoBehaviour
{
    private GameObject gO;
    public GameObject gM;

    void OnCollisionEnter(Collision collision)
    {
        gO = this.gameObject;

        if (collision.gameObject.tag == "Player")
        {
            CollectCan();
        }
    }

    private void CollectCan()
    {
        gM.GetComponent<Gasoline>().gas++;
        gM.GetComponent<Gasoline>().hasGas = true;
        Destroy(gO);
    }
}
