using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnIlaButtonClick() {
        Parameters.PlayerName = "bimba";
        SceneManager.LoadScene("Level1");
    }

    public void OnManuButtonClick()
    {
        Parameters.PlayerName = "manu";
        SceneManager.LoadScene("Level1");
    }
}
