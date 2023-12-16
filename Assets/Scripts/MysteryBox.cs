using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBox : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float itemSpeed;
    public float timerLength;
    float timer;
    public PowerupManager pm;
    
    powerups currentPowerUp;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, Mathf.PingPong(Time.time*2, 3)-3);
        rb.velocity = Vector2.left * itemSpeed;
        //Debug.Log(Mathf.Sin(Time.deltaTime) * 2000);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != 7) return;
        Debug.Log("CONNECTION!IFHIOWFHWEO");
        
        int rand = Random.Range(1, 4);

        switch (rand)
        {
            case 1:
                currentPowerUp = powerups.GRAVITY_SUIT;
                break;
            case 2:
                currentPowerUp = powerups.TELEPORTER;
                break;
            case 3:
                currentPowerUp = powerups.SPEEDUP;break;
            case 4:
                currentPowerUp = powerups.SCORE_BONUS; break;
            default: break;
            
        }
        pm.StartPowerUp(currentPowerUp);
        Destroy(gameObject);
    }
}
