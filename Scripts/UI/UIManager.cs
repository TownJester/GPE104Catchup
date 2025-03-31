using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateText(string textInput){
        text.text = textInput;
    }
}
