using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideMoveAster : MonoBehaviour
{
    private float time;
    public float swingWidth;
    private Rigidbody2D _rb;
    private SurfaceEffector2D _se;
    Vector3 defaultPos;
    Vector3 prevPos;
    public Vector2 velocity;
    
    void Start()
    {
        time=0f;
        defaultPos=transform.position;
        _rb=GetComponent<Rigidbody2D>();
        _se=GetComponent<SurfaceEffector2D>();
        
    }
    void FixedUpdate(){
        prevPos=_rb.position;
        Vector3 pos=new Vector3(defaultPos.x+Mathf.PingPong(Time.time,3),defaultPos.y,0);
        _rb.MovePosition(pos);
        velocity=((pos-prevPos)/Time.deltaTime);
        _se.speed=velocity.x;
    }
}
