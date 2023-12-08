using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDListData : ScriptableObject
{
    public List<ColorID> ColorIDList;

    public ColorID currentColor;
    public int num;
    public void SetCurrentColorRandomly()
    {
        num = Random.Range(0, ColorIDList.Count);
        currentColor = ColorIDList[num];
    }
}
