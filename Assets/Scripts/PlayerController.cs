using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    void Start()
    {
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * x * speed * Time.fixedDeltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500f);
            GameObject.Find("Road").GetComponent<Scrolling>().enabled = false;
            GameObject.Find("Grass").GetComponent<Scrolling>().enabled = false;
            // list of script Rolling in the child components of the player
            Rolling[] rollings = GetComponentsInChildren<Rolling>();
            foreach (Rolling rolling in rollings)
            {
                rolling.enabled = false;
            }
            GameObject.Find("Spawn").GetComponent<Spawn>().StopSpawn();
            Destroy(gameObject.GetComponent<PlayerController>());
        }
    }
}