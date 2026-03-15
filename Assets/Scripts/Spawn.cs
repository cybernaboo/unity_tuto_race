using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    [SerializeField] float spawnRate = 2f;
    [SerializeField] GameObject[] cars;
    [SerializeField] Transform[] spawns;
    Quaternion spawnRotation = Quaternion.Euler(0, 180f, 0);
    int totalCars = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

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
            Instantiate(cars[Random.Range(0, cars.Length)], spawns[Random.Range(0, spawns.Length)].position, spawnRotation);
            totalCars++;
            if (totalCars % 10 == 0)
                spawnRate -= 0.1f;
            spawnRate = Mathf.Clamp(spawnRate, 0.3f, 5.0f);
        }
    }
}
