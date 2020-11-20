using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearColor : MonoBehaviour
{

    public void ClearButton(int c)
    {
        RandomColorText.instance.ChangeColorToDefault(c);

    }
}
