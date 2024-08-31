using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    [SerializeField] private float jumpForce = 5f;


    private bool canJump = true;
    private bool isJumping = false;

    private Rigidbody2D rigidbody2D;


    void OnEnable()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            canJump = false;
        }
    }

    private void FixedUpdate()
    {
        if (!canJump && !isJumping)
        {
            rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
        isJumping = false;
    }
}
