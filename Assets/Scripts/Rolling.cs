using UnityEngine;

public class Rolling : MonoBehaviour
{
    [SerializeField] int rotationSpeed = 800;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
