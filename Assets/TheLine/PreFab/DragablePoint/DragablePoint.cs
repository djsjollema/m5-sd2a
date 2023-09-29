using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragablePoint : MonoBehaviour
{
    public bool dragging = false;

    void Update()
    {
        Vector2 mousePosition = Input.mousePosition;
        if (dragging)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            this.transform.position = mousePosition;
        }
    }

    private void OnMouseDown()
    {
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;
    }
}
