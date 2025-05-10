using UnityEngine;

public class mover : MonoBehaviour
{
    public float speed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //오브젝트 움직임
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}
