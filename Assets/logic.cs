using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    public int plscore;
    public Text score;
    public GameObject gameover;
    

    [ContextMenu("Increase Score")]
    public void addScore(int scoreAdd)
    {
        plscore = plscore + scoreAdd;
        score.text = plscore.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   public void gameOver()
    {
        gameover.SetActive(true);
    }

    
}
