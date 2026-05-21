using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Player")]
    float moveSpeed = 5f;
    public float JumpForce = 10f;
    public Rigidbody2D rb;

    private Vector2 movement;

    private float moveX;

    [Header("Ground")]
    public LayerMask GroundLayer;
    public BoxCollider2D GroundCollider;
    public bool OnGround;
    public bool canJump;
      public bool crouching;


    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       OnGround = true;
       canJump = true;
    }
    void Update()
    {
        //moves left and right
        moveX = Input.GetAxisRaw("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space) && OnGround && canJump == true)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
            OnGround = false; 
            crouching =false;
        } 

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(GroundLayer == (1 << other.gameObject.layer))
        {
            OnGround = true;
            crouching =false;
        }

    }

    void FixedUpdate()
    {
       
       if (rb.position.y < - 3.6890f)
        {
            movement = new Vector2(moveX * moveSpeed, GetComponent<Rigidbody2D>().linearVelocity.y);
            rb.linearVelocity = movement;
            canJump = true;
        }
        else{
            canJump = false;
            rb.linearVelocity = movement;

        }

}
}