using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public float Damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();
        if(health != null){
            health.TakeDamage(Damage);
        }
        // Destroys itself
        Destroy(gameObject);
    }
}
