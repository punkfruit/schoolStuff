using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterColorChanger : MonoBehaviour
{

    public Color[] colors;
    public SpriteRenderer spr;
    public int colorIndex = 0;


    public void ChangeColor()
    {
        spr.color = colors[colorIndex];
        colorIndex++;

        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }
}
