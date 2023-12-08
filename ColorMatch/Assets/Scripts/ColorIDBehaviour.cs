using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehaviour : IDcontainer
{
    public ColorIDListData colorIDDataListObj;

    private void Awake()
    {
        IDOBJ = colorIDDataListObj.currentColor;
    }
}
