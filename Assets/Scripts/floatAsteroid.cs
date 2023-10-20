using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatAsteroid : MonoBehaviour
{
    private float time;
    private float iniY;
    public float swingHeight;
    public float speed;

    void Start()
    {
        time=0f;
        iniY=transform.position.y;
    }


    void Update()
    {
        transform.position=new Vector3(transform.position.x,iniY+Mathf.PingPong(Time.time/speed,swingHeight),0);
        
    }
}
