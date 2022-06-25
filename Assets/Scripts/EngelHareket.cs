using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelHareket : MonoBehaviour
{
    //public GameObject engel;
    //public float engelHizi;

    public KeyCode yukari = KeyCode.W;
    public KeyCode asagi = KeyCode.S;
    public float engelHizi = 6;
    public float sinir = 3;
    private Rigidbody2D engel;


    void Start()
    {
        engel = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var hiz = engel.velocity;

        if (Input.GetKey(yukari))
        {
            hiz.y = engelHizi;
        }
        else if (Input.GetKey(asagi))
        {
            hiz.y = -engelHizi;
        }
        else
        {
            hiz.y = 0;
        }
        engel.velocity = hiz;

        var pozisyon = transform.position;
        if (pozisyon.y > sinir)
        {
            pozisyon.y = sinir;
        }
        else if (pozisyon.y < -sinir)
        {
            pozisyon.y = -sinir;
        }
        transform.position = pozisyon;

        //Hareket();
    }

    //private void Hareket()
    //{
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        gameObject.transform.Translate(0, engelHizi, 0);
    //    }
    //    if (Input.GetKey(KeyCode.S)) 
    //    { 
    //        gameObject.transform.Translate(0, -engelHizi, 0);
    //    }
    //}


}
