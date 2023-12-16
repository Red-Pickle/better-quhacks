using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public enum states
{
    PREGAME,
    INGAME,
    INGAME_SLOW,
    INGAME_FAST,
    DEAD,
    TITLESCREEN
}
public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
   

    public states currentGameState;
    public TextMeshProUGUI scoreText;
    public float score;
    public int scoreMultiplier;
    public int highScore;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentGameState)
        {
            case states.TITLESCREEN:
                
                break;
            case states.PREGAME:
                currentGameState = states.INGAME;
                break;
            case states.INGAME:
                score += Time.deltaTime*scoreMultiplier; break;
            case states.INGAME_SLOW:
                score += Time.deltaTime*scoreMultiplier / 2; break;
            case states.INGAME_FAST:
                score += Time.deltaTime*scoreMultiplier * 2; break;
            case states.DEAD:
                break;
            default:
                break;
            
        }
        if(score > highScore)
        {
            highScore = (int)score;
        }
        scoreText.text = ((int)score).ToString();
    }


}
