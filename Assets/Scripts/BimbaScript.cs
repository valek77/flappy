using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BimbaScript : MonoBehaviour
{

    public float Forza;

    Rigidbody2D rb;
    bool partito;
    public GameObject tapHere;

    bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        partito = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameOver)
        {

            if (!partito)
            {
                partito = true;
                rb.isKinematic = false;
                tapHere.SetActive(false);

            }
            else
            {
                rb.AddForce(new Vector2(0, Forza));
            }

        }
    }

    private void StoppaTutto()
    {
        PuntiManager.Instance.registraPunteggio();
        UIManager.Instance.HandleGameOver();
        Spawner.Instance.StopSpawn();
        //this.gameObject.SetActive(false);
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;

        GetComponent<Animator>().Play("BimbaCollisione");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tronco")
        {
            gameOver = true;

            StoppaTutto();



        }

        if (collision.gameObject.tag == "Punti")
        {
            if (!gameOver)
                PuntiManager.Instance.IncrementaPunti();
            else
                Debug.Log("Game Over");
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Terreno")
        {
            StoppaTutto();
        }
    }
}
