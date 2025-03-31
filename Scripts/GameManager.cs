using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public UIManager UiManager;
    public int Lives = 3;
    public int AstroidCount = 5;
    public int score = 0;

    public void Awake(){

        if (instance == null)
        {
        instance = this;
        DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PrintVictory(){
        Debug.Log("You Win!");
    }

    public void ReduceLivesOne(){
        Lives--;
        if (Lives <= 0){
            PrintLoss();
        }
    }
    public void ReduceAstroOne(){
        AstroidCount--;
        if (AstroidCount <= 0){
            PrintVictory();
        }
    }
        public void ScoreIncrease(int amount){
            score += amount;
            UiManager.UpdateText("" + score);
        }
    public void PrintLoss(){
        Debug.Log("Game Over");
    }
}
