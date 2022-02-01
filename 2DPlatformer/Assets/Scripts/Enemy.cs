using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D body;
    public Animator animator;
    public LayerMask groundLayer;
    public float movementSpeed = 4f;

    private float movementDirection = 1f;

    private void Update()
    {

        Vector3 rayDirection = new Vector2(movementDirection, 0);
        Debug.DrawLine(transform.position, transform.position + rayDirection, Color.red);
        if (Physics2D.Raycast(transform.position, rayDirection, rayDirection.magnitude, groundLayer.value))
        {
            movementDirection = -movementDirection;
            Vector2 scale = transform.localScale;
            scale.x = -movementDirection;
            transform.localScale = scale;
        }

        Vector2 movement = body.velocity;
        movement.x = movementDirection * movementSpeed;

        body.velocity = movement;
    }
}
