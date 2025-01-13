using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rig;

    public float BulletSpeed;


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



}
