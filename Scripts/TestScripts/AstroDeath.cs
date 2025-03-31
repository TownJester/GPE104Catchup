using UnityEngine;

public class AstroDeath : Death
{
    public int ScoreAmountIncrease;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }
    public override void Die(){
        if (GameManager.instance != null){
            GameManager.instance.ReduceAstroOne();
            GameManager.instance.ScoreIncrease(ScoreAmountIncrease);
            Destroy(gameObject);
        }
    }
}
