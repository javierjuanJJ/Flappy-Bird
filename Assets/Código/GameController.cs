using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool gameOver;
    public static GameController instance;
    public GameObject gameOverText;
    public float scrollSpeed = -1.5f;
    
    private static int score;

    public void BindScore()
    {
        
    }
    // Start is called before the first frame update
    private void Awake()
    {
        if (GameController.instance == null)
        {
            GameController.instance = this;
        }
        else if (GameController.instance != this)
        {
            Destroy(gameObject);
        }
        
    }
    
    private void onDestroy()
    {
        if (GameController.instance == this)
        {
            GameController.instance = null;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    
    public void BirdDie()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
