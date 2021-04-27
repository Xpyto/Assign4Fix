using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*if(Input.GetButton("up") && isGrounded){
            transform.position += new Vector3(0f, moveSpeed, 0f);
        }*/
        if(Input.GetButton("left")){
            transform.position += new Vector3(moveSpeed, 0f, 0f);
        }   
        if(Input.GetButton("right")){
            transform.position += new Vector3(-1*moveSpeed,0f, 0f);
        }
    }

    private void OnCollisionExit2D(Collision2D collider){
        Invoke("NoGround",3f);
    }

    private void OnCollisionStay2D(Collision2D collider){
        if(collider.gameObject.CompareTag("Floor")){
            isGrounded = true;
        }
    }

    void NoGround(){
        isGrounded = false;
    }
}
