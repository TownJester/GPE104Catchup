using UnityEngine;
using UnityEngine.UI;

public class AstroHealthBar : MonoBehaviour
{
        public Image HealthBar;
        public Health Health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void ChangeFillAmount(){
            if(HealthBar != null && Health != null){
                float HealthRatio = Health.CurrentHealth / Health.MaxHealth;
                HealthBar.fillAmount = HealthRatio;
            }
        }
}
