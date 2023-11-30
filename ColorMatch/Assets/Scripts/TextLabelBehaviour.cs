using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextLabelBehaviour : MonoBehaviour
{
    public TextMeshProUGUI label;
    public UnityEvent startEvent;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        // UpdateLabel();
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
       label.text = obj.value.ToString();
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString();
    }
}
