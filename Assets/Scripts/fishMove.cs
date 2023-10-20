using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fishMove : MonoBehaviour
{
    private Rigidbody2D _rb;
    private SpriteRenderer _rend;
    private SpriteRenderer _arrowRend;
    private GameObject _cat;
    private GameObject _pressSK;
    private GameObject _Arrow;
    private walk _walk;
    public AudioClip keySound;
    AudioSource _audioSource;

    void Start()
    {
        _cat=GameObject.Find("Cat-6-Idle_0");
        _pressSK=GameObject.Find("pressSK");
        _Arrow=GameObject.Find("Arrow");
        _rb=GetComponent<Rigidbody2D>();
        _rend=GetComponent<SpriteRenderer>();
        _arrowRend=_Arrow.GetComponent<SpriteRenderer>();
        _walk=_cat.GetComponent<walk>();
        _audioSource=GetComponent<AudioSource>();
        _rend.enabled=false;
        _walk.enabled=false;
        _arrowRend.enabled=false;
        _rb.bodyType=RigidbodyType2D.Kinematic;
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            _audioSource.PlayOneShot(keySound);
            _rend.enabled=true;
            _rb.bodyType=RigidbodyType2D.Dynamic;
        }
        if(transform.position.y<-10){
            Destroy(this);
            _walk.enabled=true;
            _arrowRend.enabled=true;
            Destroy(_pressSK);
        }
        
    }
}
