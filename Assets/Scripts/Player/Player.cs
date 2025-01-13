using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rig;
    public Animator anim;


    public float speed;

    public float jumpForce;

    private bool isJumping;


    public GameObject bulletPrefab; // prefabs é usado GameObject

    public Transform FirePoint; // em qualquer coisa usa o transform que ai usamos só o "position e o rotation" em vez de por "transform" na frente dos dois

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rig.velocity = new Vector2(speed, rig.velocity.y);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rig.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            anim.SetBool("Jumping", true);
            isJumping = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
             Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            anim.SetBool("Jumping", false);
            isJumping= false;
        }
    }

}
