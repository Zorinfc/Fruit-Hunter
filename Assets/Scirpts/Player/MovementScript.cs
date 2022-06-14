using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private bool grounded;

    [SerializeField] private AudioClip  _jump;
    [SerializeField] private float speed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
   }

    

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

        if (horizontalInput > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1,1,1);
        }

        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            Jump();
            anim.SetTrigger("jump");
            
        }
        
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded",grounded);
    }

    private void Jump()
    {        
        SoundManager.Instance.PlaySound(_jump);
        rb.velocity = new Vector2(rb.velocity.x, speed * 1.2f);
        grounded = false;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "FallDetector")
            {
                SceneManager.LoadScene(4);
            }
        }
}
