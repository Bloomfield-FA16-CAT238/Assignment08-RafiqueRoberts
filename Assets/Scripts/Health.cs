using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Slider healthBar;
    public int health;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        health = 100;

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "enemy")

        {
            health -= 2;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (healthBar.name == "HealthBar")
        {
            healthBar.value = health;
        }

    }
}
