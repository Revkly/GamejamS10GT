using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrollenemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private CircleCollider2D col;
    public float kecepatanGerak;
    public bool balik;

    // Start is called before the first frame update
    void Start()
    {
        balik = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (balik)
        {
            rb.velocity = new Vector2(kecepatanGerak, rb.velocity.y);
        }
        else 
        {
            rb.velocity = new Vector2(-kecepatanGerak, rb.velocity.y);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("balik"))
        {
            balik = !balik;
        }
    }
}
