using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;





public class LogicScript : MonoBehaviour
{
    public bool stageactive = true;
    public int stage;
    public int playerScore;
    public GameObject spawner2;
    public GameObject spawner;
    public GameObject pipe ;
    public Text scoreText;
    public GameObject GameOverScreen;
    public bool newstage;


     void start()
    {
       
    }




    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    [ContextMenu("Increase Scoreeeee")]
    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }


    public void waveover()
    {
        stage = stage +  1;
        stageactive = false;
        
    }


    public void spawneractive()
    {
        spawner.SetActive(false);
    }

    public void spawneractive2()
    {
        spawner2.SetActive(false);
    }

    public void pipeactive()
    {
        pipe.SetActive(false);
    }




    void Update()
    {
        if(playerScore > 24)
        {
            waveover();
            spawneractive2();
            spawneractive();
            pipeactive();
        }

        

    }


}