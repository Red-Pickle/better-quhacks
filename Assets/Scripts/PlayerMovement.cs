using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float speed;
    public bool grounded;
    public LayerMask whatIsGround;
    public float playerHeight;
    public float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*speed, rb.velocity.y);
        if(Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y-(playerHeight/2)), Vector2.down, 0.15f, whatIsGround))
        {
            grounded = true;
            Debug.Log("grounded!");
        }
        else
        {
            grounded = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && grounded){
            Jump();
        }
    }

    void Jump()
    {
        Debug.Log("Jumping!");
        if (grounded)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            grounded = false;
        }
    }
}
