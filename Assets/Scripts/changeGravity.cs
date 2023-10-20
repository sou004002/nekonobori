using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeGravity : MonoBehaviour
{

    void Start()
    {
  
    }
    void Update()
    {
        if(transform.position.y>140.0f){
            Physics2D.gravity=new Vector2(0f,-4.9f);
            }
        else{
            Physics2D.gravity=new Vector2(0f,-9.81f);
        }
    }
}
