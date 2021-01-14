using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntiManager : MonoBehaviour
{
    public int punti;

    public static PuntiManager Instance;

    private static readonly string RECORD_KEY = "Record";

    private static readonly string PUNTI_KEY = "Punti";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }


    public void IncrementaPunti() 
    {
        punti++;
    }


    public void registraPunteggio()
    {
        PlayerPrefs.SetInt(PUNTI_KEY, punti);

        if (PlayerPrefs.HasKey(RECORD_KEY))
        {
            int rec = PlayerPrefs.GetInt(RECORD_KEY);
            if (punti > rec) {
                PlayerPrefs.SetInt(RECORD_KEY, punti);
            }
        }
        else 
        {
            PlayerPrefs.SetInt(RECORD_KEY, punti);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
