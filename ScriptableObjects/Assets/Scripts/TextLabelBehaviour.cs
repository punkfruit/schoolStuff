using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextLabelBehaviour : MonoBehaviour
{
    public TextMeshProUGUI label;
    public FloatData dataOBJ;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = dataOBJ.value.ToString();
    }
}
