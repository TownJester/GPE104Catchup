using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

public void StartGame(string level){
    SceneManager.LoadScene(level);
}
public void Settings(string GUI){
    SceneManager.LoadScene(GUI);
}
}
