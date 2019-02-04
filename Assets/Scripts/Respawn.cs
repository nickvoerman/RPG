using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform[] spawners;
    public GameObject enemy;

    public float waitTime;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Wait()
    {
        Invoke("SpawnEnemy", waitTime);
    }


    public void SpawnEnemy()
    {
        int spawnPointIndex = Random.Range(0, spawners.Length);
        Instantiate(enemy, new Vector2(spawners[spawnPointIndex].position.x, spawners[spawnPointIndex].position.y), Quaternion.identity);
    } 
}
