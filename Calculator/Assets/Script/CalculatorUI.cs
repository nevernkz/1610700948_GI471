using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorUI : MonoBehaviour
{
    public Text displayText;
    

    
    void Start()
    {
        
        Calculator.instance.OnInput += OnInput;
        //Calculator.instance.Input("");
   
    }

    
   
    public void OnInput(string input)
    {
        Debug.Log(input);
        displayText.text = input ;
    }

    public void soundIndex(string sound)
    {
        soundIndex(sound);

    }
}
