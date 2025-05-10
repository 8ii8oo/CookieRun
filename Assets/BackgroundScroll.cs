using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed;
    public MeshRenderer meshRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //스크롤 속도를 매쉬에 적용
        meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
    }
}
