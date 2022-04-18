using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBomb : MonoBehaviour
{
    public Transform[] randomPositionBomb;
    public GameObject bomb;
    private int random;
    private bool flag;

    private void Start()
    {
        random = Random.Range(0, randomPositionBomb.Length);

    }
    void Update()
    {
        if (!flag)
        {
            RandomPointSpawn();
            flag = true;
        }

    }

    private void RandomPointSpawn()
    {
        Instantiate(bomb, randomPositionBomb[random].position, Quaternion.identity);
    }

    
    
}
