using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float CurrentHealth;
    public float MaxHealth;
    public AstroHealthBar AstroHealthBar;

    public Death deathComponent;

    // Start is called before the first frame update
    void Start()
    {
        deathComponent = GetComponent<Death>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Heal(float amount)
    {
        CurrentHealth = CurrentHealth + amount;

        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);

        if (AstroHealthBar != null){
            AstroHealthBar.ChangeFillAmount();
        }
    }

    public void TakeDamage(float amount)
    {
        CurrentHealth = CurrentHealth - amount;

        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);

        if (AstroHealthBar != null){
            AstroHealthBar.ChangeFillAmount();
        }

        if (CurrentHealth <= 0)
        {

            // Die
            deathComponent.Die();
        }
    }

    public bool IsAlive()
    {
        if (CurrentHealth > 0)
        {
            return true;
        }

        return false;
    }
}
