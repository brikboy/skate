using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    float maxSpeed = 20f;
    Animator anim;
    bool facingRight = true;
    float jumpForce = 700f;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", grounded);


        float move = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        anim.SetFloat("Speed", Mathf.Abs(move));

        if (move > 0 && !facingRight)
        {
            Flip();
        } else if (move < 0 && facingRight)
        {
            Flip(); 
        }
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)  && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x = scale.x * -1;
        transform.localScale = scale;
    }
}
