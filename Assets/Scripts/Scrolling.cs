using UnityEngine;

public class Scrolling : MonoBehaviour
{
    [Range(0.0f, 3f)]
    [SerializeField] float speed = 1f;
    Renderer renderer;
    float offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * speed;
        //print(offset);
        //renderer.Off
        renderer.material.SetTextureOffset("_BaseMap", new Vector2(0, -offset));
    }
}
