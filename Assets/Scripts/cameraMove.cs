using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cameraMove : MonoBehaviour
{
    public GameObject apple;

    void Start()
    {
        
    }


    void Update()
    {
        Vector3 cameraPos=new Vector3(transform.position.x,apple.transform.position.y,-10);
        transform.position=cameraPos; 
    }
}
