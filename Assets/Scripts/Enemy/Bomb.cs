using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Bomb : MonoBehaviour
{
    private Rigidbody2D rig;


    public float xAxis;
    public float yAxis;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector2(xAxis, yAxis), ForceMode2D.Impulse);

        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
}
