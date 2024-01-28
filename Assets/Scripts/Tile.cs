using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tile : MonoBehaviour
{

    public Button buttonPrefab;
    public Vector2 cornerBottomLeft = Vector2.one;
    public Vector2 cornerTopRight = Vector2.one;
    public Vector2 offsetMax = Vector2.zero;
    public Vector2 offsetMin = Vector2.zero;

    private void Start()
    {
    
    }

    public void CreateTile(Canvas canvasParent)
    {
        CreateButton(buttonPrefab, canvasParent, cornerTopRight, cornerBottomLeft, offsetMax, offsetMin);
    }

    public static Button CreateButton(Button buttonPrefab, Canvas canvasParent, Vector2 cornerTopRight, Vector2 cornerBottomLeft, Vector2 offsetMax, Vector2 offsetMin)
    {
        var button = Object.Instantiate(buttonPrefab, Vector3.zero, Quaternion.identity) as Button;
        var rectTransform = button.GetComponent<RectTransform>();
        rectTransform.SetParent(canvasParent.transform);
        rectTransform.anchorMax = cornerTopRight;
        rectTransform.anchorMin = cornerBottomLeft;
        rectTransform.offsetMax = Vector2.zero;
        rectTransform.offsetMin = Vector2.zero;
        return button;
    }

}
