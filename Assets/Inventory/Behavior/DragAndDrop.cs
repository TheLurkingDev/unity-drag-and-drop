using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField]
    private Canvas _canvas;
    private RectTransform _rectTransform;

    private void Start()
    {
        if(_canvas == null)
        {
            throw new System.Exception("You must add the Canvas to the DragAndDrop script component.");
        }
        _rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("You started dragging me...");        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("You are still dragging me...");
        _rectTransform.anchoredPosition += eventData.delta / _canvas.scaleFactor;
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
