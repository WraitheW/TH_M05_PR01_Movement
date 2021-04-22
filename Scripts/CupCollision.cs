using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupCollision : MonoBehaviour
{
    public GameManager gm;

    void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "trash" || collision.gameObject.tag == "cup")
        {
            Debug.Log("Checkpoint 1");
            Destroy(collision.collider.gameObject);
            gm.AddScore();
        }
    }
}
