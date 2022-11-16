using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5.0f;
    public float jumpPower = 5.0f;
    private bool canJump = false;

    public Image gameOver;

    private Rigidbody2D Rigidbody;
    private Animator playerAnimator;
    private void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }
    private void Update()
    {
        MovePlayer();
        Jump();
    }
    private void MovePlayer()
    {

        var horizontalInput = Input.GetAxisRaw("Horizontal");

        if (horizontalInput == 0)
        {
            playerAnimator.SetBool("isJalan", false);
            return;
        }

        Rigidbody.velocity = new Vector2(horizontalInput * playerSpeed, Rigidbody.velocity.y);
        playerAnimator.SetBool("isJalan", true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            canJump = true;

        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            gameOver.gameObject.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Trap"))
        {
            gameObject.SetActive(false);
            gameOver.gameObject.SetActive(true);
        }
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && canJump)
        {
            Vector2 jumpV = new Vector2(0f, jumpPower);
            Rigidbody.velocity += jumpV;
            canJump = false;
        } 
    }




/*    private bool IsGrounded()
    {
        var groundCheck = Physics2D.Raycast(transform.position, Vector2.down, 0.7f);
        return groundCheck.collider != null && groundCheck.collider.CompareTag("Ground");
    }*/

}
