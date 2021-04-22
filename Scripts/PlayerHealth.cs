using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth = 100;
    public TMP_Text healthText;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            ZombieAttack();
        }
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + playerHealth.ToString();
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void ZombieAttack()
    {
        playerHealth -= 5;
    }

}
