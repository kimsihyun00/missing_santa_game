using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Vector2 buttonsPlace;

    private Vector2 initialPos;

    private float deltaX, deltaY;

    public static bool matched = false;

    void Start()
    {
        initialPos = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0 && !matched)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                    }
                    break;
                case TouchPhase.Moved:
                    if (GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(touchPos))
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                    break;
                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - buttonsPlace.x) <= 0.5f &&
                        Mathf.Abs(transform.position.y - buttonsPlace.y) <= 0.5f)
                    {
                        transform.position = new Vector2(buttonsPlace.x, buttonsPlace.y);
                        matched = true;
                    }
                    else
                    {
                        transform.position = new Vector2(initialPos.x, initialPos.y);
                    }
                    break;
            }
        }
    }
}
