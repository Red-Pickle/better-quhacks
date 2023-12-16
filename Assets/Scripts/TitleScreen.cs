using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public Button titleButton;
    public Button exitButton;
    public ScoreManager sm;

    void Start()
    {
        titleButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayGame()
    {
        gameObject.SetActive(false);
        sm.currentGameState = states.PREGAME;
    }

    void ExitGame()

    {

    }
}
