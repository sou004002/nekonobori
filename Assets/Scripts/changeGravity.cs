using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeGravity : MonoBehaviour
{
    // public float groundGravity=9.81f;
    // public float spaceGravity=4.905f;
    // public Rigidbody2D _rb;
    // private bool _isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        // _rb=GetComponent<Rigidbody2D>();
        // _isGrounded=false;    
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Physics2D.gravity);
        // _isGrounded=GetComponent<walk>().isGrounded();
        if(transform.position.y>140.0f){
            Physics2D.gravity=new Vector2(0f,-4.9f);
            }
        else{
            Physics2D.gravity=new Vector2(0f,-9.81f);
        }
    }
}
