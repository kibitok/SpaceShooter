using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroy : MonoBehaviour
{
    public float DestroyTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
       // Invoke("Die", DestroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Die()
    {
        StartCoroutine("Destroy");
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);

    }

}
