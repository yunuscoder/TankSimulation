using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

    int health;
    public Text PlayerCan;

    // Use this for initialization
    void Start()
    {
        health = 100;
        PlayerCan.text = health.ToString();

    }


    public void TakeDamage(int amount)
    {
        health -= (amount * 10);

        if (health <= 0)
        {
            health = 0;
            Die();
        }
        PlayerCan.text = health.ToString();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
