using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private float startPosx;
    private float startPosy;
    private bool isBeingHeld = false;

    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld == true){

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosx, mousePos.y - startPosy, 0);
        }
    }

    private void OnMouseDown()
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        startPosx = mousePos.x - this.transform.localPosition.x;
        startPosy = mousePos.y - this.transform.localPosition.y;

        isBeingHeld = true;
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}
