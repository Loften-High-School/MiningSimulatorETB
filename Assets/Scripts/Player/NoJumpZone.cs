using UnityEngine;

public class NoJumpZone : MonoBehaviour
{
    public bool colliding;
    public Move move;

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

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col == true)
        {
            Debug.Log("yellow no jump muahaha");
            colliding = true;
        }
        else
        {
            colliding = false;
            Debug.Log("awe man you can jump");
        }
    }
}
