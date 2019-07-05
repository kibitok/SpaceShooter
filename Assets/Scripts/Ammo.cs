using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float Damage = 100f;
    public float lifetime = 2f;

   void OnEnable()
    {
        CancelInvoke();
        Invoke("Die", lifetime);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Health H = collision.gameObject.GetComponent<Health>();
        if (H == null)
        {
            return;
        }
        H._healthpoints -= Damage;

    }
    void Die()
    {
        gameObject.SetActive(false);
    }

}
