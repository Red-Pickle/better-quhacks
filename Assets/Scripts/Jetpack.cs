using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    Rigidbody2D rb;
    public float jetpackForce;
    public ScoreManager sm;
    public ParticleSystem jetpackParticlesPrefab;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jetpackParticlesPrefab.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jetpackParticlesPrefab.Play();
        }
        if (Input.GetKey(KeyCode.Space)  && sm.currentGameState!=states.DEAD && sm.currentGameState != states.TITLESCREEN)
        {
            rb.velocity = new Vector2(0, jetpackForce);
            
        }
        if (Input.GetKeyUp(KeyCode.Space))
            jetpackParticlesPrefab.Stop();
            
    }
}
