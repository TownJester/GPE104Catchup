using UnityEngine;

public class ShootBullet : MonoBehaviour
{

    public GameObject BulletPrefab; 
    public Transform BSpawn;
    public float LifeTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PewPew(){
        GameObject SpawnBullet = Instantiate (BulletPrefab, BSpawn.position, BSpawn.rotation);
        Destroy (SpawnBullet, LifeTime);
    }
}
