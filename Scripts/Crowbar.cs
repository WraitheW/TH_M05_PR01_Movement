using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowbar : MonoBehaviour
{
    GameManager gm;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            collision.other.gameObject.GetComponent<ZombieHealth>().CrowbarAttack();
            gm.AddScore();
        }
    }
}
