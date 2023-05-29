using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy2")
        {
            AudioManager.instance.Play("EnemyDamage");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if(collision.tag == "Zombie")
        {
            collision.GetComponent<Zombie>().TakeDamege(25);
        }
    }
}
