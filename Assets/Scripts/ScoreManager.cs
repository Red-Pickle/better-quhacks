using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public enum states
    {
        INGAME,
        INGAME_SLOW,
        INGAME_FAST,
        DEAD
    }

    public states currentGameState;
    public TextMeshProUGUI scoreText;
    float score;
    public int scoreMultiplier;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentGameState)
        {
            
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
        scoreText.text = ((int)score).ToString();
    }


}
