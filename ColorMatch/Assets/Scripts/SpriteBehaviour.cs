using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spr;
    public UnityEvent startEvent;

    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        startEvent.Invoke();
    }

   
    public void ChangeSpriteColor(ColorID col)
    {
        spr.color = col.value;
    }


    public void SetSPR(bool state)
    {
        spr.enabled = state;
    }
}
