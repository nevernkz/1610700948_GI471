using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public GameObject popup;
    public void OpenPopup()
    {
        if (popup!=null)
        {
            bool isActive = popup.activeSelf;
            popup.SetActive(!isActive);
        }
    }
}
