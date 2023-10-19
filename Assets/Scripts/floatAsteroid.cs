using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatAsteroid : MonoBehaviour
{
    private float time;
    private float iniY;
    // private float iniX;
    public float swingHeight;
    // public float swingWidth;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        time=0f;
        iniY=transform.position.y;
        // iniX=transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Mathf.PingPong(Time.time/speed,swingWidth));
        // Debug.Log(Mathf.PingPong(Time.time/speed,swingHeight));
        transform.position=new Vector3(transform.position.x,iniY+Mathf.PingPong(Time.time/speed,swingHeight),0);
        
    }
}
