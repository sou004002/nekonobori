using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blinkingText : MonoBehaviour
{
    private Text PStext;
    private int t;
    // Start is called before the first frame update
    void Start()
    {
        PStext=GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        t=(int)Time.time;
        if(t%2==0){
            PStext.enabled=true;
        }
        else{
            PStext.enabled=false;
        }
        
    }
}
