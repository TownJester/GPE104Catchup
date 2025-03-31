using UnityEngine;
using UnityEngine.UI;

public class UpdateHealthbar : MonoBehaviour
{
    public Image HealthBar;
    public ShipHealth health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeFillAmount(){
        if (HealthBar != null && health != null){
            float HealthRatio = health.CurrentHealth / health.MaxHealth;
            HealthBar.fillAmount = HealthRatio;
        }
    }
}
