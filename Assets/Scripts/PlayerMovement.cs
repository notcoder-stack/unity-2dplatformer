using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed; // Speed of the player movement
    private float Move;

    public float jump;

    public float dash;

    public bool isJumping;

    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.linearVelocity= new Vector2(speed * Move, rb.linearVelocity.y);  

        if(Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.linearVelocity.x, jump));
        }

        if(Input.GetKey(KeyCode.CapsLock))
        {
            rb.AddForce(new Vector2(dash, rb.linearVelocity.y));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
