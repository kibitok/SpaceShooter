using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject DeathParticlesprefabs;
    private Transform thisTransform;
    public bool ShouldDestroyOnDeath;
    [SerializeField]
    public float _healthpoints = 100f;

    // Start is called before the first frame update
    void Start()
    {
        thisTransform = GetComponent<Transform>();
    }
    //public float HealthPoints
    //{
    //    get
    //    {
    //        return _healthpoints;
    //    }
    //    set
    //    {
    //        _healthpoints = value;
    //        if (_healthpoints <= 0f)
    //        {
    //           // SendMessage("Die", SendMessageOptions.DontRequireReceiver);


    //                //Instantiate(DeathParticlesprefabs, thisTransform.position, thisTransform.rotation);
    //                Debug.Log("on Death");


    //            if (ShouldDestroyOnDeath)
    //            {
    //                Destroy(gameObject);
    //            }
    //        }
    //    }
    //}


    void FixedUpdate()
    {
        

    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
       // Destroy(DeathParticlesprefabs);
    }





    // Update is called once per frame
    void Update()
    {
        healthpoints();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _healthpoints = 0f;
        }
    }

   void healthpoints()
    {
        if (_healthpoints <= 0f)
        {
            SendMessage("Die", SendMessageOptions.DontRequireReceiver);
            

            Instantiate(DeathParticlesprefabs, thisTransform.position, thisTransform.rotation);

            StartCoroutine("Destroy");
        }
    }
}

