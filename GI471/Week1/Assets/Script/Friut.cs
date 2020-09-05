using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Friut : MonoBehaviour
{
    // Start is called before the first frame update

    public Text text;
    public Text text1, text2, text3, text4;
    
    List<string> fruit = new List<string>();
    
    
    
    private void Start()
    {
        
        fruit.Add("Apple");
        fruit.Add("Orange");
        fruit.Add("Carrot");
        fruit.Add("Strawberry");
        fruit.Add("Banana");
        fruit.Add("");
        




    }
    void Update()
    {
        

       

        if (Input.GetKeyDown(KeyCode.Return))
        {
            
            fruit.RemoveAt(0);


            

            if (text4.text == "Banana")
            {
                text4.text = null;
            }
            else if (text3.text == "Banana")
            {
                text3.text = "";
            }

            else if (text2.text == "Banana")
            {
                text2.text = "";
            }
            else if (text1.text == "Banana")
            {
                text1.text = "";
            }
            else if (text.text == "Banana")
            {
                text.text = "";
           
               
            }
            else if(text.text=="")
            {
                text.text ="Item is Empty";
            }
 
        }
        text.text = fruit[0];
        text1.text = fruit[1];
        text2.text = fruit[2];
        text3.text = fruit[3];
        text4.text = fruit[4];

    }
   
}
