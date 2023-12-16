using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    Rigidbody2D rb;
    public float jetpackForce;
    public ScoreManager sm;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)  && sm.currentGameState!=states.DEAD && sm.currentGameState != states.TITLESCREEN)
            rb.velocity = new Vector2(0, jetpackForce);
    }
}
