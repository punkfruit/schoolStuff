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
    public IntData data2OBJ;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        if(dataOBJ != null)
        {
            label.text = dataOBJ.value.ToString();
        }
        


        if(data2OBJ != null)
        {
            label.text = data2OBJ.value.ToString();
        }
    }
}
