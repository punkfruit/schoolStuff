using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehaviour : MonoBehaviour
{
    private Camera cameraOBJ;
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;

    // Start is called before the first frame update
    void Start()
    {
        cameraOBJ = Camera.main;
        
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraOBJ.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();
        

        while(draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraOBJ.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable= false;
        endDragEvent.Invoke();
    }
}
