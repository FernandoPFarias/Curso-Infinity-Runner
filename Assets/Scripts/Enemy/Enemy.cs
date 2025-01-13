using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int damage;


    public virtual void ApplyDamege(int dmg)
    {
        health -= dmg;

        if(health <=0) 
        { 
           Destroy(gameObject); 
        }

    }


    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            ApplyDamege(2);
        }
    }

}
