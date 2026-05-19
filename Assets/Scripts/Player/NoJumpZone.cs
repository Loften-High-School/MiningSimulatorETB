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
            
        }
        
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        Debug.Log("yellow no jump muahaha");
        colliding = true;
        
    }
}
