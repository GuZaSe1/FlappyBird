using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    [SerializeField] float time = 2f;

    [SerializeField] float minY = -2f, maxY = 2f;

    void Start()
    {
        InvokeRepeating(nameof(Spawns), time, time);
    }

    void Update()
    {

    }
    void Spawns()
    {
        GameObject newPipes = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        newPipes.transform.position += new Vector3(0,Random.Range(minY, maxY));
    }
}
