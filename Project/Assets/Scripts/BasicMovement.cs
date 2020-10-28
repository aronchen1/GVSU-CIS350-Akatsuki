using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    public Animator animator;

    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
     
    }

    void jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
            animator.SetBool("isGrounded", true);
        }


    }

    public void OnLanding()
    {
        animator.SetBool("isGrounded", false);
    }
}
