using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D body;
    public Animator animator;
    public LayerMask groundLayer;
    public float jumpForce = 4f;
    public float movementSpeed = 4f;

    private Vector2 spawnPoint;

    private void Start()
    {
        spawnPoint = transform.position;
    }

    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        bool jump = Input.GetButtonDown("Jump");
        bool grounded = IsGrounded();

        if (jump && grounded)
            Jump();

        Vector2 velocity = body.velocity;
        velocity.x = movement * movementSpeed;
        body.velocity = velocity;

        if (movement != 0)
        {
            Vector2 scale = transform.localScale;
            scale.x = Mathf.Sign(movement);
            transform.localScale = scale;
        }

        if (!grounded && body.velocity.y > 0)
        {
            animator.Play("Jump");
        }
        else if (!grounded && body.velocity.y < 0)
        {
            animator.Play("Fall");
        }
        else if (Mathf.Abs(body.velocity.x) > 0.1f)
        {
            animator.Play("Run");
        }
        else
        {
            animator.Play("Idle");
        }

    }

    private void Jump()
    {
        body.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
    }

    private bool IsGrounded()
    {
        Vector3 rayDirection = Vector3.down;
        Debug.DrawLine(transform.position, transform.position + rayDirection, Color.red);
        if (Physics2D.Raycast(transform.position, rayDirection, rayDirection.magnitude, groundLayer.value))
            return true;

        return false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Enemy"))
            return;

        transform.position = spawnPoint;
    }
}
