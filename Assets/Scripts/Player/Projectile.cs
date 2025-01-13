using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rig;

    public float BulletSpeed;

    public int damage;


    public GameObject ExplosionEffect;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject,5f);
    }

    private void FixedUpdate()
    {
        rig.velocity = Vector2.right * BulletSpeed;
    }

    public void OnHit()
    {
        
        GameObject Explosion =Instantiate(ExplosionEffect, transform.position, transform.rotation);
        Destroy(gameObject); /// aqui eu estou destruindo a bala
        Destroy(Explosion,1f); /// aqui eu estou destruindo a animação de explosão da bala

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            OnHit();
        }
    }



}
