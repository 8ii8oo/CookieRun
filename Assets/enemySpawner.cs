using Unity.VisualScripting;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject[] gameObjects;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Invoke("SpawnEnemy", 2f);
    }

    // Update is called once per frame
    void Update()
    {

           
    }
    void SpawnEnemy() //적 스포너
    {
        
        GameObject randomObject = gameObjects[Random.Range(0, gameObjects.Length)]; //랜덤하게 생성
        float prefabY = randomObject.transform.position.y;
        Vector3 spawnPosition = new Vector3(transform.position.x, prefabY, 0f);
        Instantiate(randomObject, spawnPosition, Quaternion.identity);
        Invoke("SpawnEnemy", 2f);
    }
}
