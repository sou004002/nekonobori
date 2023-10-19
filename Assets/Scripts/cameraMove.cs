using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cameraMove : MonoBehaviour
{
    public GameObject apple;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos=new Vector3(transform.position.x,apple.transform.position.y,-10);
        transform.position=cameraPos;
        // diff=(transform.position.y-apple.transform.position.y);
        // if(Math.Abs(diff)>7.0f){
        //     if(diff>0){
        //         transform.position=new Vector2(transform.position.x,transform.position.y-diff);
        //     }
        //     else{
        //         transform.position=new Vector2(transform.position.x,transform.position.y+diff);
        //     }
        // }
        
    }
}
