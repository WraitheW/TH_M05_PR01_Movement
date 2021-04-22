using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engines : MonoBehaviour
{
    private GameObject gO;
    public GameObject gM;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Checkpoint 1.5");
        gO = this.gameObject;

        if (collision.gameObject.tag == "Player")
        {
            if (gM.GetComponent<Gasoline>().gas > 0)
            {
                FuelEngine();
            }
            else
            {
                Debug.Log("Ya outa gas silly");
            }
            Debug.Log("Checkpoint 2");
        }
    }

    private void FuelEngine()
    {
        gM.GetComponent<Gasoline>().gas--;
        gM.GetComponent<GameManager>().engineCount--;
    }
}
