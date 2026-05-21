using UnityEngine;

public class NoJumpZone : MonoBehaviour
{
    public bool colliding;
    public Move move;
    public float lin;
    public Move crouching;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         lin = move.rb.linearVelocity.y ;


        
    }

    void OnTriggerStay2D (Collider2D col)
    {
    
        if (crouching==true )
        {
            Debug.Log(col.gameObject.name + " : " + gameObject.name );
            Debug.Log("yellow no jump muahaha");
            colliding = true;
            move.canJump = false;
        }
        
       
    }
    void OnTriggerExit2D (Collider2D col)
    {
        
        
            Debug.Log(col.gameObject.name + " : " + gameObject.name );
            colliding = false;
            if (crouching==false)
            {
                move.canJump = true;
                Debug.Log("awe man you can jump");
            }
            

        
    }
}
