using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public Button restart;
    public Button title;
    public ScoreManager sm;
    public Rigidbody2D rb;
    public GameObject player;
    public TextMeshProUGUI text;
    public TextMeshProUGUI highscore;
    void Start()
    {
        restart.onClick.AddListener(RestartGame);
        title.onClick.AddListener(TitleScreen);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + ((int)sm.score).ToString();
        highscore.text = "High Score: " + sm.highScore.ToString();
    }

    void RestartGame()
    {
        gameObject.SetActive(false);
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        rb.velocity = Vector3.zero;
        sm.score = 0;
        player.transform.eulerAngles = Vector3.zero;
        player.transform.position = new Vector2(-6, 0);
        sm.currentGameState = states.PREGAME;
    }

    void TitleScreen()
    {

    }
}
