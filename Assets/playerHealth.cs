using Unity.VisualScripting;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float playerHp = 60f;
    private float enemyDamage = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Update() 
    {
        playerHp -= 1f * Time.deltaTime;
        if(playerHp <= 0)
        {
            Die();
        }
    }
    void OnTriggerEnter2D(Collider2D other) //적과 닿았을 때 hit
    {
        if(other.gameObject.CompareTag("enemy"))
        {
            Hit();
        }
    }
        void Hit() //hit: 적의 데미지만큼 플레이어 체력 감소
    {
        playerHp -= enemyDamage;
    }
    void Die() //삭제
    {
        Destroy(gameObject);
    }
}
