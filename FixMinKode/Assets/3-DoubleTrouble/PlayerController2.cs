using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController2 : MonoBehaviour
{
    public float jumpForce = 8f;
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
        float horizontal = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontal -= 1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontal += 1;
        }
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);

        bool jump = Input.GetKeyDown(KeyCode.UpArrow);
        if (jump && isGrounded)
        {
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    
    void CheckGround()
    {
        isGrounded = Physics2D.OverlapCircle(transform.position, 0.2f, 1 << LayerMask.NameToLayer("Ground"));
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Interact2"))
        {
            Debug.Log("Interacting with " + collision.gameObject.name);
        }
    }
}
