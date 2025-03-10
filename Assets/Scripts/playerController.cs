using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    public Rigidbody2D theRB;


    private void Update()
    {
        theRB.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), theRB.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
        }
    }
}
