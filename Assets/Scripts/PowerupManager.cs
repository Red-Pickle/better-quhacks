using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public enum powerups
{
    NONE,
    INVINCIBILITY,
    SPEEDUP,
    SCORE_BONUS
}

public class PowerupManager : MonoBehaviour
{
    public bool is_invincible = false;

    public powerups in_powerup = powerups.NONE;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator wait_for_end()
    {
       yield return new WaitForSeconds(7);
        EndPowerUp(in_powerup);
    }

    public void StartPowerUp(powerups powerUp)
    {
        if (powerUp == powerups.INVINCIBILITY)
        {
            is_invincible = true;
        }
        else if (powerUp == powerups.SPEEDUP)
        {
            GameObject.Find("Player").GetComponent<PlayerMovement>().speed += 10;
        }
        else if (powerUp == powerups.SCORE_BONUS)
        {
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().score += 500;
        }

        in_powerup = powerUp;
        StartCoroutine(wait_for_end());
    }

    public void EndPowerUp(powerups powerUp)
    {
        if (powerUp == powerups.INVINCIBILITY)
        {
            is_invincible = false;
        }
        else if (powerUp == powerups.SPEEDUP)
        {
            GameObject.Find("Player").GetComponent<PlayerMovement>().speed -= 10;
        }
        in_powerup = powerups.NONE;
    }
}