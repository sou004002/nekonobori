using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneChange : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        if(transform.position.y<-10){
            Initiate.Fade("main", Color.black, 1.25f);
        }
        
    }
}
