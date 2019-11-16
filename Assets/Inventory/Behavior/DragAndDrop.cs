using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("You started dragging me...");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("You are still dragging me...");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("You stopped dragging me...");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("You clicked me!");
    }
}
