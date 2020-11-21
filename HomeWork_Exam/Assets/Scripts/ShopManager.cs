using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ShopManager : MonoBehaviour
{

    public int[,] shopItems = new int[11,11];
    public float Money;
    public Text MoneyText;
    public GameObject popup;
    public GameObject popup2;
    
    void Start()
    {
        
        
        //ไอเท็ม
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        shopItems[1, 7] = 7;
        shopItems[1, 8] = 8;
        shopItems[1, 9] = 9;
        shopItems[1, 10] = 10;


        //ราคา
        shopItems[2, 1] = 100;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 420;
        shopItems[2, 5] = 525;
        shopItems[2, 6] = 86;
        shopItems[2, 7] = 97;
        shopItems[2, 8] = 78;
        shopItems[2, 9] = 89;
        shopItems[2, 10] = 110;

        //จำนวน
        shopItems[3, 1] = 5;
        shopItems[3, 2] = 5;
        shopItems[3, 3] = 5;
        shopItems[3, 4] = 5;
        shopItems[3, 5] = 5;
        shopItems[3, 6] = 5;
        shopItems[3, 7] = 5;
        shopItems[3, 8] = 5;
        shopItems[3, 9] = 5;
        shopItems[3, 10] = 5;



        

    }
    public void Update()
    {
        MoneyText.text = "Money : " + Money.ToString();
        
        

    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (Money >= shopItems[2, ButtonRef.GetComponent<Button>().ItemID])
        {
            if (shopItems[3, ButtonRef.GetComponent<Button>().ItemID]>0)
            {
                Money -= shopItems[2, ButtonRef.GetComponent<Button>().ItemID];
                shopItems[3, ButtonRef.GetComponent<Button>().ItemID]--;
                MoneyText.text = "Money:" + Money.ToString();
                ButtonRef.GetComponent<Button>().QuantityText.text = shopItems[3, ButtonRef.GetComponent<Button>().ItemID].ToString();
                OpenPopup();
                if (Money < shopItems[2, ButtonRef.GetComponent<Button>().ItemID])
                {
                    OpenPopUp2();
                }

            }

        }
        else
        {
            OpenPopUp2();

        }
       


    }
    public void AddMoney()
    {
        Money+=1000;
    }

    public void OpenPopup()
    {
        if (popup != null)
        {
            bool isActive = popup.activeSelf;
            popup.SetActive(!isActive);
           
            
        }
    }
    
    public void OpenPopUp2()
    {
        if (popup2 != null)
        {
            bool isActive = popup2.activeSelf;
            popup2.SetActive(!isActive);


        }
    }

}
