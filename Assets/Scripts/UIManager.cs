using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Text puntiText;
    public Text HighScoreText;
    public GameObject gameOverPanel;
    public GameObject gameOverText;

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

    public void HandleGameOver() {
        HighScoreText.text = "High Score :" + PlayerPrefs.GetInt("Record");
        gameOverPanel.SetActive(true);
        gameOverText.SetActive(true);
    }


    public void OnButtonReplayClick()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnButtonMenuClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
