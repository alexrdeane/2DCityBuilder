using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshRenderer))]
public class HighlighObject : MonoBehaviour
{
    public float animationTime = 1f;
    public float threshold = 1.5f;

    private Material material;
    private Color normalColor;
    private Color selectedColor;

    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;

        normalColor = material.color;
        selectedColor = new Color
        (
            Mathf.Clamp01(normalColor.r * threshold),
            Mathf.Clamp01(normalColor.g * threshold),
            Mathf.Clamp01(normalColor.b * threshold)
        );
    }

    public void StartHighlight()
    {

    }
}
