using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isMoveFloor : MonoBehaviour
{
    private bool _isGrounded;
    private bool isCol;
    public GameObject _moveFloor;
    private Vector2 _addVelocity;
    private Rigidbody2D _rb;

    void Start()
    {
        isCol=false;
        _moveFloor=GameObject.Find("SideMoveAster");
        _rb=GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        _isGrounded=GetComponent<walk>().isGrounded();
        _addVelocity=_moveFloor.GetComponent<sideMoveAster>().velocity;
        Vector2 vel=_rb.velocity;
        // Debug.Log(vel+_addVelocity);
        Vector2 newVel=new Vector2((vel+_addVelocity).x,0f);
        if(_isGrounded&& isCol){
            _rb.velocity=(newVel);
            // Debug.Log("!!");
        }  
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="moveFloor"){
            isCol=true;
        }
    }
    void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.tag=="moveFloor"){
            isCol=false;
        }
    }

}
