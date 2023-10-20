using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isActiveCanvas : MonoBehaviour
{
    private GameObject _cat;
    private bool _isActCan;
    public Canvas canvas;

    void Start()
    {
        _cat=GameObject.Find("Cat-6-Idle_0");
        canvas.enabled=false;
        
    }

    void Update()
    {
        _isActCan=_cat.GetComponent<walk>().isActCan;
        if(_isActCan){
            canvas.enabled=true;
        }
        
    }
}
