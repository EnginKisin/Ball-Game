using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skor : MonoBehaviour
{

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.name == "Top")
    //    {
    //        string duvarIsmi = transform.name;
    //        OyunYönetim.Skor(duvarIsmi);
    //        collision.gameObject.SendMessage("YenidenBaslat", 1.0f, SendMessageOptions.RequireReceiver);
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Top"))
        {
            string duvarIsmi = transform.name;
            OyunYönetim.Skor(duvarIsmi);
            collision.gameObject.SendMessage("YenidenBaslat", 2.0f, SendMessageOptions.RequireReceiver);
        }
    }
}
