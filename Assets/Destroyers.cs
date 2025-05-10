using UnityEngine;

public class Destroyers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroySc();
    }
    void DestroySc(){ //화면 밖으로 나간 오브젝트 삭제
    if(transform.position.x < -10)
        {
        Destroy(gameObject);
        }
    }
}
