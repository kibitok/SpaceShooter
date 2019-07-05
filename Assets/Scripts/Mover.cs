using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Transform thisTranform;
    public float MaxSpeed = 5f;
    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {

        thisTranform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(thisTranform);
        thisTranform.position += new Vector3(-MaxSpeed*Time.deltaTime, 0,0);
    }
   
}
