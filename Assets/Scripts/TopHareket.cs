using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareket : MonoBehaviour
{
    private Rigidbody2D top;
    void Start()
    {
        top = GetComponent<Rigidbody2D>();
        Invoke("TopHareketi", 2);

    }


    void Update()
    {

    }

    void TopHareketi()
    {
        float r = Random.Range(0, 2);
        if (r < 1)
        {
            top.AddForce(new Vector2(500, -300));
        }
        else
        {
            top.AddForce(new Vector2(-500, -300));
        }
    }

    void TopuSýfýrla()
    {
        top.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void YenidenBaslat()
    {
        TopuSýfýrla();
        Invoke("TopHareketi", 0.5f);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Top"))
        {
            Vector2 v;
            v.x = top.velocity.x;
            v.y = (top.velocity.y / 2) + (collision.collider.attachedRigidbody.velocity.y / 3);
            top.velocity = v;
        }
    }
}
