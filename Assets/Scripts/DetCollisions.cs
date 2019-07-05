using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetCollisions : MonoBehaviour
{
    public float DamageRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        Health H = collision.gameObject.GetComponent<Health>();
        if (H == null)
        {
            return;
        }
        H._healthpoints -= DamageRate * Time.deltaTime;

    }
}
