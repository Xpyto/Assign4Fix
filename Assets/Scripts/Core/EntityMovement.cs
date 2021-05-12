using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement player;
    bool isMoving;
    Vector3 savedVelocity;
    Vector3 currVelocity;
    Rigidbody2D erb;

    private void Awake() {
        erb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        savedVelocity = new Vector3();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.isMoving = player.isMoving;
        if(isMoving){
            currVelocity = erb.velocity;
        }
        if(!isMoving){
            savedVelocity = currVelocity;
            erb.velocity = new Vector3(0, 0, 0);
            erb.gravityScale = 0;
            
        }else{
            erb.velocity = savedVelocity + Vector3.down;
            erb.gravityScale = 1;
        }
    }
}
