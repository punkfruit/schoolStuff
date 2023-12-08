using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;

    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data Obj)
    {
        Instantiate(prefab, Obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList Obj)
    {
        for(var i = 0; i < Obj.vector3Dlist.Count; i++)
        {
            Instantiate(prefab, Obj.vector3Dlist[i].value, Quaternion.identity);
        }
    }


    public void CreateInstanceFromListCounting(Vector3DataList Obj)
    {
      
        Instantiate(prefab, Obj.vector3Dlist[num].value, Quaternion.identity);
        num++;
        if(num == Obj.vector3Dlist.Count)
        {
            num = 0;
        }
    }

    public void CreateInstanceRandom(Vector3DataList Obj)
    {
        num = Random.Range(0, Obj.vector3Dlist.Count - 1);
        Instantiate(prefab, Obj.vector3Dlist[num].value, Quaternion.identity);
        
    }

}
