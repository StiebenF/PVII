using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float maxSpeed = 50f;


    private float horizontal;
    private Vector2 direction;

    private Rigidbody2D rigidbody2D;


    void OnEnable()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        direction = new Vector2(horizontal, 0);
    }

    void FixedUpdate()
    {
        if (rigidbody2D.velocity.magnitude < maxSpeed)
        {
            rigidbody2D.AddForce(direction * speed);
        }
    }
}
