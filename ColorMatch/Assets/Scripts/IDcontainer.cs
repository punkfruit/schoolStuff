using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDcontainer : MonoBehaviour
{
    public ID IDOBJ;
    public UnityEvent startEvent;

    private void Start()
    {
        startEvent.Invoke();
    }
}
