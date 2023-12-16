using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KillPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public ScoreManager sm;
    public float deathForce;
    public Button button;
    public GameObject deathScreen;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        button.onClick.AddListener(Death);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Death()
    {
        sm.currentGameState = states.DEAD;
        rb.constraints = RigidbodyConstraints2D.None;
        rb.AddForce(new Vector2(deathForce, 0), ForceMode2D.Impulse);
        Invoke("ShowDeathScreen", 2.5f);
    }

    public void ShowDeathScreen()
    {
        deathScreen.SetActive(true);
    }
}
