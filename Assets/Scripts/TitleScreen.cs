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
    public Rigidbody2D rb;
    public GameObject player;

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
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        rb.velocity = Vector3.zero;
        sm.score = 0;
        player.transform.eulerAngles = Vector3.zero;
        player.transform.position = new Vector2(-6, 0);
        sm.currentGameState = states.PREGAME;
    }

    void ExitGame()

    {

    }
}
