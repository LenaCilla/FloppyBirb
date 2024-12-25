using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicscript : MonoBehaviour
{
    public int plscore;
    public Text score;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        plscore = plscore + 1;
        score.text = plscore.ToString();
    }
}
