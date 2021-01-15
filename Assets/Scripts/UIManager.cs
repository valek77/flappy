using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Text puntiText;

    private void Awake()
    {
        if (Instance == null) {
            Instance = this;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntiText.text = PuntiManager.Instance.punti.ToString();
    }
}
