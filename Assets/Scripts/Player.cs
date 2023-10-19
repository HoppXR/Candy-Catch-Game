using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] private float speed;
    [SerializeField] private float jump;

    bool isGrounded;

    private Vector2 _moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        InputManager.Init(this);
        InputManager.SetGameControls();
    }

    void Update()
    {
        transform.position += (Vector3)(_moveDirection * speed * Time.deltaTime);
    }

    public void PlayerJump(Vector2 currentDirection)
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    public void SetMovementDirection(Vector2 currentDirection)
    {
        _moveDirection = currentDirection;
    }
}
