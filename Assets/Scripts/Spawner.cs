using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxY = 7;
    public float spawnTimeInterval = 1;
    public GameObject gruppoTronchi;

    bool partito = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if (!partito)
            {
                InvokeRepeating("spawn", 0, spawnTimeInterval);
                partito = true;
            }

        }
    }


    private void spawn() {
        Instantiate(gruppoTronchi, new Vector3(transform.position.x, Random.Range(-maxY, maxY), 0), Quaternion.identity);
    }

    public void StopSpawn() {

        CancelInvoke("spawn");
    }
}
