using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehaviour : MatchBehaviour
{
    public ColorIDListData colorIDDataListObj;

    private void Awake()
    {
        idobj = colorIDDataListObj.currentColor;
    }

    public void ChangeColor(SpriteRenderer spr)
    {
        var newColor = idobj as ColorID;
        spr.color = newColor.value;
    }
}
