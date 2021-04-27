using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed;
    float jumpMultiplier;
    float jumpVelocity;
    float fallMultiplier;
    bool isGrounded;
    public bool isMoving;

    float distToGround;

    Rigidbody2D rb;
    Collider2D cd;
    

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        cd = GetComponent<Collider2D>();
    }

    void Start()
    {
        moveSpeed = 5f;
        jumpMultiplier = 2f;
        jumpVelocity = 6f;
        fallMultiplier = 2.5f;
        isGrounded = true;
        isMoving = false;
        distToGround = cd.bounds.extents.y;
    }

    void Update()
    {
        if(Input.GetButton("Jump") && isGrounded){
            rb.velocity = Vector2.up * jumpVelocity;
        }

        if(Mathf.Abs(Input.GetAxisRaw("Horizontal"))==1){
            transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed, 0f, 0f);
        }
        
        //Debug.Log(isGrounded);

        if(rb.velocity.y < 0){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }else if(rb.velocity.y > 0 && !Input.GetButton("Jump")){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (jumpMultiplier - 1) * Time.deltaTime;
        }

        
    }

    
    private void OnCollisionStay2D(Collision2D other) {
        CheckIfGrounded();
    }
 
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("Floor")){
        isGrounded = false;
        }
    }
 
    
    /*void IsGrounded(){
        isGrounded = Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }*/

    private void CheckIfGrounded()
{
    RaycastHit2D[] hits;

    //We raycast down 1 pixel from this position to check for a collider
    Vector2 positionToCheck = transform.position;
    hits = Physics2D.RaycastAll (positionToCheck, new Vector2 (0, -1), 0.05f);

    //if a collider was hit, we are grounded
    if (hits.Length > 0) {  
        isGrounded = true;
    }
}
}