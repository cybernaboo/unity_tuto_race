using UnityEngine;

public class Rolling : MonoBehaviour
{
    [SerializeField] Vector3 direction = Vector3.right;
    [SerializeField] int rotationSpeed = 800;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(direction * rotationSpeed * Time.deltaTime);
    }
}
