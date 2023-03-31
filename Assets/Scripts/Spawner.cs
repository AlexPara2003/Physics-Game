using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject spawnPrefab;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Tab))
        {
            Instantiate(spawnPrefab, transform.position, transform.rotation);
        }
    }
}