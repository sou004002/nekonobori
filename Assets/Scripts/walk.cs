using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class walk : MonoBehaviour
{
    private float speed = 4.0f;
    private float ladderSpeed=6.0f;
    private float jumpForce=19.5f;
    private Rigidbody2D _rb;
    private Animator _anim;
    private SpriteRenderer _rend;
    private float maxJumpTime=25.0f;
    private float jumpTime=0;
    public LayerMask groundLayer;
    private bool jumpnow=false;
    private bool jumpst=false;
    private float InputX=0f;
    private float InputY=0f;
    private float t;
    public bool isActCan=false;
    public bool isUpKey=false;
    public AudioClip jump;
    AudioSource _audioSource;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); 
        _anim = GetComponent<Animator>();
        _rend=GetComponent<SpriteRenderer>();
        _audioSource=GetComponent<AudioSource>();

    }


    void Update()
    {
        t=Time.deltaTime;
        InputX = Input.GetAxisRaw("Horizontal");
        InputY=Input.GetAxisRaw("Vertical");
        if(Input.GetKeyDown(KeyCode.Space)&& isGrounded()){
        }
        else if(Input.GetKey(KeyCode.Space)){
            if(isGrounded()){
                InputX=0;
                _anim.SetBool("jumpend",false);
                _anim.SetBool("jumpstart",true);
                if(jumpTime<maxJumpTime){
                jumpTime+=t*100f;
                }
            }
            jumpst=true;
        }
        else if(Input.GetKeyUp(KeyCode.Space) && isGrounded()){
            _audioSource.PlayOneShot(jump);
            Jump();
            jumpTime=0;
            jumpst=true;
        }
        else if(jumpst && !isGrounded()){
            jumpnow=true;
            jumpst=false;
        }
        else if(jumpnow && isGrounded()){

            jumpnow=false;
            _anim.SetBool("jumpend",true);
            _anim.SetBool("jumpstart",false);
        }

        _rb.velocity=(new Vector2(InputX*speed,_rb.velocity.y));
        _anim.SetBool("sidewalk",InputX!=0);
        if(Input.GetAxisRaw("Horizontal")>0.01f){
        _rend.flipX=false;
        }
        else if(Input.GetAxisRaw("Horizontal")<-0.01f){
        _rend.flipX=true;
        }
   
    }

    void Jump()
    {
        _rb.AddForce(Vector2.up*jumpForce*jumpTime);
    }
    public bool isGrounded()
    {
        RaycastHit2D hit=Physics2D.Raycast(transform.position,Vector2.down,0.6f,groundLayer);
        return hit.collider!=null;
    }
    void OnTriggerStay2D(Collider2D collider){
        if(collider.gameObject.tag=="ladder"){
            if(InputY>0.01f){
            _anim.SetBool("jumpend",true);
            _anim.SetBool("jumpstart",false);
            _rb.velocity=(new Vector2(InputX*speed,InputY*ladderSpeed));   
            }
        }

    }
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag=="fish"){
            isActCan=true;
            this.enabled=false;
        }
        if(collider.gameObject.tag=="upkey"){
            isUpKey=true;
        }
    }
    
    void OnTriggerExit2D(Collider2D collider){
        if(collider.gameObject.tag=="upkey"){
            isUpKey=false;
        }
    }

}
