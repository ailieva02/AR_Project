using UnityEngine;

public class DraggablePiece : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private Camera arCamera;

    void Start()
    {
        // Initialize AR Camera
        arCamera = Camera.main;
    }

    void Update()
    {
        // Handle touch input for mobile devices
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = touch.position;
            touchPosition.z = arCamera.nearClipPlane;

            Vector3 worldPosition = arCamera.ScreenToWorldPoint(touchPosition);
            HandleDragging(touchPosition, touch.phase);
        }
        // Handle mouse input for desktop
        else if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = arCamera.nearClipPlane;

            Vector3 worldPosition = arCamera.ScreenToWorldPoint(mousePosition);
            HandleDragging(mousePosition, Input.GetMouseButton(0) ? TouchPhase.Moved : TouchPhase.Ended);
        }
    }

    void OnMouseDown()
    {
        // Start dragging
        isDragging = true;
        Vector3 screenPosition = arCamera.WorldToScreenPoint(transform.position);
        offset = transform.position - arCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z));
    }

    void OnMouseUp()
    {
        // Stop dragging
        isDragging = false;
    }

    private void HandleDragging(Vector3 inputPosition, TouchPhase touchPhase)
    {
        if (isDragging)
        {
            Vector3 screenPosition = arCamera.WorldToScreenPoint(transform.position);
            Vector3 worldPosition = arCamera.ScreenToWorldPoint(new Vector3(inputPosition.x, inputPosition.y, screenPosition.z)) + offset;

            // Log values for debugging
            Debug.Log($"Input Position: {inputPosition}");
            Debug.Log($"World Position: {worldPosition}");
            Debug.Log($"Current Position: {transform.position}");

            // Update x and z positions while keeping y unchanged
            transform.position = new Vector3(worldPosition.x, transform.position.y, worldPosition.z);
        }
    }
}
