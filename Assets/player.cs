using Microsoft.Unity.VisualStudio.Editor;
using NUnit.Framework;
using UnityEngine;

public class player : MonoBehaviour
{
    public float jumpPower = 1.0f;
    public Rigidbody2D rigid;
    private int maxJumpCount = 2;
    public int jumpCount = 0;
    public Sprite[] jump;
    public Sprite[] slider;
    public SpriteRenderer sprite;
    public CapsuleCollider2D collid;
    bool isGround = true;
    Animator ani;
    Vector2 sliderSize = new Vector2(0.8f, 0.4f);
    Vector2 orignalSize;
    

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        collid = GetComponent<CapsuleCollider2D>();
        ani = GetComponent<Animator>();
        orignalSize = collid.size;
    }

    void Update()
    {
        //C키를 눌렀을 때 점프, 최대 2단점프(슬라이드 불가능)
        if(Input.GetKeyDown(KeyCode.C) && jumpCount < maxJumpCount)
        {
            rigid.linearVelocity = new Vector2(0, jumpPower);
            jumpCount ++;
            sprite.sprite = jump[0]; //점프시 이미지 변경
            ani.enabled = false;
            isGround = false;
        }

        Sllider(); //점프
    
        if(Input.GetKeyUp(KeyCode.Z)) //슬라이드가 끝나면 원래대로 돌아오기
        {
            collid.size = orignalSize;
            ani.enabled = true;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
         //ground와 닿았을때 점프 횟수 초기화(슬라이드 가능)
        if(collision.gameObject.name == "ground")
        {
            jumpCount = 0;
            ani.enabled = true;
            isGround = true;
        }
    }
    void Sllider() //슬라이드
    {
         if(Input.GetKey(KeyCode.Z) && isGround)
        {
            collid.size = sliderSize;
            ani.enabled = false;
            sprite.sprite = slider[0];
        }
    }
}
