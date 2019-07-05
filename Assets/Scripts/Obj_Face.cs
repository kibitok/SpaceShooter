using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_Face : MonoBehaviour
{
    public GameObject objtoFollow;
    public bool followplayer = false;
    public float MaxSpeed = 1f;

    public Transform thisTransform;
    //public GameObject playerObject;

    void Awake()
    {
        thisTransform = GetComponent<Transform>();

       // if (!followplayer)
       // {
       //     return;
       // }
       // GameObject playerObject = GameObject.FindGameObjectWithTag("player");
       //if (playerObject != null)
       // {
       //     objtoFollow = playerObject.GetComponent<Transform>();
       // }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (objtoFollow == null)
        //{
        //    return;
        //}
        Vector2 dirtoObj = objtoFollow.transform.position - thisTransform.position;
        float angle = Mathf.Atan2(dirtoObj.y, dirtoObj.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        thisTransform.rotation = Quaternion.Slerp(transform.rotation, rotation, MaxSpeed*Time.deltaTime);
        //if (dirtoObj != Vector2.zero)
        //{
        //    //float angle = Mathf.Atan2(dirtoObj.y, dirtoObj.x) * Mathf.Rad2Deg;
        //    //Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //    //thisTransform.rotation = Quaternion.Slerp(transform.rotation, rotation, MaxSpeed * Time.deltaTime);

        //    thisTransform.localRotation = Quaternion.LookRotation(dirtoObj.normalized, Vector2.up);
        //}
    }

}
