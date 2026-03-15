using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    [SerializeField] float spawnRate = 2f;
    [SerializeField] GameObject car;
    Quaternion spawnRotation = Quaternion.Euler(0, 180f, 0);

    void Start()
    {
        StartCoroutine(SpawnCar());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnCar()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(car, Vector3.zero, spawnRotation);
        }
    }
}
