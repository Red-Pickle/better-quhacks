using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum powerups
{
    NONE,
    GRAVITY_SUIT,
    TELEPORTER,
    SPEEDUP,
    SCORE_BONUS
}
public class PowerupManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartPowerUp(powerups powerUp)
    {
        Debug.Log(powerUp.ToString());
    }
}
