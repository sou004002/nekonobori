using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDownPlants : MonoBehaviour
{
    public GameObject _cat;
    public GameObject spriteObj;
    private Vector3 plantDefaultPos;
    public float hideTime;
    public float returnTime=3.0f;
    private bool _isGrounded;
    private bool _isPlanted;
    private bool isHide;
    private bool isReturn;
    private BoxCollider2D _col;
    private Rigidbody2D _rb;
    private bool isCol;
    private SpriteRenderer _rend;
    private Color _color;
    private float Timer=0.0f;
    private float hidingTimer=0.0f;
    public float colorChangeSpeed;
    public bool isChangeColor=false;
    public bool isChangeAlpha=false;
    private Color32 defalutColor;
    public bool isStartTimer=false;

    void Start()
    {
        _isGrounded=false;
        _isPlanted=false;
        isCol=false;
        isHide=false;
        _col=GetComponent<BoxCollider2D>();
        _rb=GetComponent<Rigidbody2D>();
        _rend=spriteObj.GetComponent<SpriteRenderer>();
        _color=_rend.color;
        _cat=GameObject.Find("Cat-6-Idle_0");
        plantDefaultPos=gameObject.transform.position;
        defalutColor=_rend.color;
        
        
    }

    void Update()
    {
        if(isChangeColor){
        _rend.color=new Color32((byte)(defalutColor.r-Timer*colorChangeSpeed),
                        (byte)(defalutColor.g-Timer*colorChangeSpeed),(byte)(defalutColor.b-Timer*colorChangeSpeed),defalutColor.a);
        }
        if(isChangeAlpha){
        _rend.color=new Color32(defalutColor.r,defalutColor.g,defalutColor.b,(byte)(defalutColor.a-Timer*colorChangeSpeed));
        }
        _isGrounded=_cat.GetComponent<walk>().isGrounded();
        _isPlanted=_isGrounded && isCol;
        if((_isPlanted && !isHide)){//着地して隠れていないなら
            isStartTimer=true;
        }
        if(Timer>hideTime){//もしタイマーがhideTimeを超えたら
            isHide=true;
            isStartTimer=false;
        }
        if(isStartTimer){
            Timer+=Time.deltaTime;
        }
        if(isReturn){
            _col.enabled=true;
            
        }
    }
    private void FixedUpdate(){
        if(isHide){
            _col.enabled=false;

            if(hidingTimer>returnTime){
                isReturn=true;
                isHide=false;
                Timer=0.0f;
                hidingTimer=0.0f;
            }
            else{
                hidingTimer+=Time.deltaTime;

            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="Player"){
            isCol=true;
        }
    }
    void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.tag=="Player"){
            isCol=false;
        }
    }

}
