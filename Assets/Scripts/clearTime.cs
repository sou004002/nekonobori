using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class clearTime : MonoBehaviour
{
    public Text clearText;
    private GameObject _cat;
    private bool _isActCan;
    private float t;

    // Start is called before the first frame update
    void Start()
    {
        _cat=GameObject.Find("Cat-6-Idle_0");
        
    }

    // Update is called once per frame
    void Update()
    {
        _isActCan=_cat.GetComponent<walk>().isActCan;
        if(_isActCan){
            clearText.text="TIME: "+t.ToString("0.0000")+"s";
        }
        else{
            t+=Time.deltaTime;
        }
        
    }
}
