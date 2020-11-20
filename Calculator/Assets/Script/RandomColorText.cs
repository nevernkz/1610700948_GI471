using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColorText : MonoBehaviour
{
    public static RandomColorText instance;

    public Text[] textColorList;

    List<Color> text = new List<Color>();
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        for (int i = 0; i < textColorList.Length; i++)
        {
            Color Color = new Color(default, default, default);

            textColorList[i].color = Color;
        }
    }

    public void ChangeColorText(int c)
    {

        Color newColor = new Color(Random.value, Random.value, Random.value);
        textColorList[c].color = newColor;
    }

    public void ChangeColorToDefault(int c)
    {
        Color newColor = new Color(default, default, default);
        textColorList[c].color = newColor;
    }
}
