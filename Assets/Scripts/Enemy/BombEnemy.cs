using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEnemy : Enemy
{
    public GameObject bombPrefab;
    public Transform firePoint;

    public float throwTime;
    private float throwCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        throwCount += Time.deltaTime;

        if (throwCount > throwTime) 
        {   
            //a bomba vem dq
            Instantiate(bombPrefab, firePoint.position, firePoint.rotation);
            throwCount = 0f;
        }

    }
}
