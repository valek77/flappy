using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BimbaScript : MonoBehaviour
{

    public float Forza;

     Rigidbody2D rb;
    bool partito;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        partito = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

            if (!partito)
            {
                partito = true;
                rb.isKinematic = false;

            }
            else 
            {
                rb.AddForce(new Vector2(0,Forza));
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
