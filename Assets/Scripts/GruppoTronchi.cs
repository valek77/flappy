using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruppoTronchi : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float velocitaX=-2;
    public float velocitaY=1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // InvokeRepeating("settaVelocita", 0, 1);
        settaVelocita();
    }

    private void settaVelocita() {
        velocitaY = -1 * velocitaY;
        rb.velocity = new Vector2(velocitaX, velocitaY);
    }

    public void ferma() {
       // CancelInvoke("settaVelocita");
        rb.velocity = Vector2.zero;
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Deleter")) {
            Destroy(gameObject);
        }

       
    }
}
