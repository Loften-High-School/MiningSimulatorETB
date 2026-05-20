using UnityEngine;

public class NoJumpZone : MonoBehaviour
{
    public bool colliding;
    public Move move;
    private Crouch crouching;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(colliding == true)
        {
            move.canJump = false;
        }
        else if(colliding == false)
        {
            move.canJump = true;
        }
        
    }
 // StILL WORKING ON THIS CROUCH Stuff /////////////


    void OnTriggerEnter2D (Collider2D col)
    {
        if (crouching == true)
        {
            Debug.Log("ew jump");
            colliding = true;
        }
    }

    void OnTriggerExit2D (Collider2D col)
    {
        if (crouching == false)
        {
            Debug.Log("yay jump");
            colliding = false;
        }
    }
}
