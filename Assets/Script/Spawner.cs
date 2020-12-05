using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinFrefab;
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
        }
    }

    void SpawnPin()
    {
        Instantiate(pinFrefab, transform.position, transform.rotation);
    }
}
