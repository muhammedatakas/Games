using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject titleList;
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI lives;
    
    public Button button;
    public Button button2;
    public bool isGameActive;
    private int pauseValue=0;
    private int score=0;
    public int live = 3;
    public float spawnRate=1;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale =pauseValue ;
            if (pauseValue == 0)
            {
                pauseValue = 1;
            }else pauseValue = 0;

        }


    }
    IEnumerator SpawnTargets()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index=Random.Range(0, targets.Count);
            Instantiate(targets[index]);
            
        }
    }
    
    public void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;

    }
    
    
        
    
    public void GameOver()
    {
        button.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitTheGame()
    {
        Application.Quit();
    }
    public void StartGame(int difficulty) {
        lives.text = "Lives : " + live;
        spawnRate /= difficulty;
        isGameActive = true;
        titleList.SetActive(false);
        StartCoroutine(SpawnTargets());
        
    }




}
