using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBg : MonoBehaviour
{
    public GameObject _camera;
    Vector3 cameraPos;
    float iniY;
    public float maxY;

    void Start()
    {
        iniY=transform.position.y;
        
    }

    void LateUpdate()
    {
        if(_camera.transform.position.y<iniY){
        cameraPos=new Vector3(transform.position.x,iniY,0);
        }
        else if(_camera.transform.position.y>maxY){
            cameraPos=new Vector3(transform.position.x,maxY,0);
        }
        else{
        cameraPos=new Vector3(transform.position.x,_camera.transform.position.y,0);
        }
        transform.position=cameraPos;
        
    }
}
