using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DusmanHealth : MonoBehaviour
{

    int health=100;
    public Text DusmanCan;

    // Use this for initialization
    void Start()
    {
        health = 100;
        DusmanCan.text = health.ToString();

    }


    public void TakeDamage(int amount)
    {
        health -= (amount * 10);

        if (health <= 0)
        {
            health = 0;
            Die();
        }
        DusmanCan.text = health.ToString();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
