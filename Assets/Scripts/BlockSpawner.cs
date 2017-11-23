using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public GameObject[] fallingBlocks;
    public float spawnSpeed;

    public float MinX;
    public float MaxX;

    public void Start()
    {
        InvokeRepeating("Spawn", 0, spawnSpeed);
    }

    public void Spawn()
    {
        float x = Random.Range(MinX, MaxX);
        
        GameObject blockPrefab = fallingBlocks[Random.Range(0, fallingBlocks.Length)];
        Instantiate(blockPrefab, new Vector2(x, 60), Quaternion.identity);
    }

    public int getDegree()
    {
         
        int degree = Random.Range(0, 3);

        return degree;
    }
}
