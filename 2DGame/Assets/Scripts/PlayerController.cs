using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private Animator playerAnimation;
    private Rigidbody2D rb;
    public Transform groundCheckPoint;
    private float groundCheckWidth = 0.5f;
    public LayerMask groundLayer;
    private bool isRunning = false, isGrounded = false, toRight = true;
    float force = 70;
    public GameObject movingScene;

    // Use this for initialization
    void Start () {
        playerAnimation = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    bool IsGrounded() {
        return Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckWidth, groundLayer);
    }

// Update is called once per frame
void Update () {
        isGrounded = IsGrounded();
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isRunning = true;
            rb.AddForce(new Vector2(100, 0));
            if(!toRight)
            {
                transform.rotation = new Quaternion(0, 0, 0, 1);
                toRight = true;
            }
        } else if(Input.GetKey(KeyCode.LeftArrow))
        {
            isRunning = true;
            rb.AddForce(new Vector2(-100, 0));
            if(toRight)
            {
                transform.rotation = new Quaternion(0, 180, 0, 1);
                toRight = false;
            }
        } else
        {
            isRunning = false;
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(transform.up * force);
        }
        playerAnimation.SetBool("isRunning", isRunning);
        playerAnimation.SetBool("isJumping", !isGrounded);
    }
}
