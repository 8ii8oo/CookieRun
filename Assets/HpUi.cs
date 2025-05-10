using UnityEngine;
using UnityEngine.UI;

public class HpUi : MonoBehaviour
{
    public playerHealth player;
    public Slider hpBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        hpBar.maxValue = player.playerHp;
        hpBar.value = player.playerHp;
    }

    // Update is called once per frame
    void Update() //체력바
    {
        hpBar.value = player.playerHp;
    }
   
}
