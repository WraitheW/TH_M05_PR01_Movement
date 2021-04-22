using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            KillZombie();
        }
    }

    public void CrowbarAttack()
    {
        health -= 50;
    }

    public void KillZombie()
    {
        Destroy(this.gameObject);
    }
}
