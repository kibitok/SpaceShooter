using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float MaxRadius = 1f;
    public float Interval = 5f;
    public GameObject ObjToSpawn;
    private Transform origin;
    // Start is called before the first frame update
     void Awake()
    {
        origin = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();

    }

    void Start()
    {
        InvokeRepeating("Spawn", 0f, Interval);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        if (origin == null)
        {
            return;
        }
        Vector2 SpawnPos = origin.position + Random.onUnitSphere * MaxRadius;
        SpawnPos = new Vector2(SpawnPos.x, 0f);

        Instantiate(ObjToSpawn, SpawnPos, Quaternion.identity);
    }
}
