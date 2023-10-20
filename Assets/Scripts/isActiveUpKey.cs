using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isActiveUpKey : MonoBehaviour
{
    private GameObject _cat;
    private bool _isActUK;
    private SpriteRenderer _rend;

    void Start()
    {
        _cat=GameObject.Find("Cat-6-Idle_0");
    }


    void Update()
    {
        _isActUK=_cat.GetComponent<walk>().isUpKey;
        _rend=GetComponent<SpriteRenderer>();
        if(_isActUK){
            _rend.enabled=true;
        }
        else{
            _rend.enabled=false;
        }
        
    }
}
