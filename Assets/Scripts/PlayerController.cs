using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    void Start()
    {

    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * x * speed * Time.deltaTime);
    }
}
