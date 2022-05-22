using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public bool gameOver = false;
    [SerializeField]
    GameObject gameOverUI;
    [SerializeField]
    GameObject crossHair;
    
    public static GameOverManager instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (GameOverManager.instance == null)
        {
            GameOverManager.instance = this;
        }
    }
    private void Start()
    {
        //gameOverUI = GameObject.Find("Canvas/GameOver");
        gameOverUI.GetComponent<Button>().onClick.AddListener(gameRestart);
    }
    public void gameOverChange()
    {
        gameOver = true;
    }
    public bool gameOverCheck()
    {
        return gameOver;
    }

    private void Update()
    {
        if (gameOver)
        {
            Debug.Log("게임 오버");
            gameOverUI.SetActive(true);
            crossHair.SetActive(false);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }


    public void gameRestart()
    {
        gameOver = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene(gameObject.scene.name);
    }
}
