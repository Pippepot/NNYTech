using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float speed = 5f;
    
    bool isGrounded = false;
    
    Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        CheckGround();
        InputMove();
    }

    void InputMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);

        bool jump = Input.GetButtonDown("Jump");
        if (jump && isGrounded)
        {
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    
    void CheckGround()
    {
        isGrounded = Physics2D.OverlapCircle(transform.position, 0.2f, 1 << LayerMask.NameToLayer("Ground"));
    }
}
