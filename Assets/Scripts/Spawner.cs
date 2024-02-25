using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] fruitPrefabs;

    private GameObject spawnedFruit;
    private Rigidbody2D fruitRigidbody;

    void Start()
    {
        SpawnRandomFruit();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (spawnedFruit == null)
            {
                SpawnRandomFruit();
            }
            else
            {
                DropFruit();
            }
        }
    }

    void SpawnRandomFruit()
    {

        int randomIndex = Random.Range(0, fruitPrefabs.Length);
        GameObject randomFruitPrefab = fruitPrefabs[randomIndex];

        spawnedFruit = Instantiate(randomFruitPrefab, transform.position, Quaternion.identity);

        spawnedFruit.transform.position = transform.position;

        fruitRigidbody = spawnedFruit.GetComponent<Rigidbody2D>();

        fruitRigidbody.isKinematic = true;
    }

    void DropFruit()
    {
        fruitRigidbody.isKinematic = false;
        spawnedFruit = null;
    }
}
