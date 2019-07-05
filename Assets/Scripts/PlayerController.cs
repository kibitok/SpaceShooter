using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D thisBody = null;
    private Transform thisTransform = null;
    public float MaxSpeed = 5f;

    void Awake()
    {
        thisBody = GetComponent<Rigidbody2D>();
        thisTransform = GetComponent<Transform>();
    }

    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - thisTransform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        thisTransform.rotation = Quaternion.Slerp(transform.rotation, rotation, MaxSpeed);
    }
}
