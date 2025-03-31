using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public float DamageDone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision){
        ShipHealth ShipHealth = collision.GetComponent<ShipHealth>();
        if (ShipHealth != null){
            ShipHealth.Ouch(DamageDone);
            Destroy(gameObject);
        }
    }
}
