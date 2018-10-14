using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvent : MonoBehaviour {

    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    SpriteRenderer sr;

    bool isEnter = false;
    bool isDown = false;
    // Use this for initialization
    protected virtual void Start () {
        sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    protected virtual void OnMouseEnter()
    {
        isEnter = true;
        updateState();
    }

    protected virtual void OnMouseExit()
    {
        isEnter = false;
        updateState();
    }

    protected virtual void OnMouseDown()
    {
        isDown = true;
        updateState();
    }

    protected virtual void OnMouseUp()
    {
        if (isDown && isEnter)
        {
            action();
        }
        isDown = false;
        updateState();
    }

    protected virtual void updateState()
    {
        if (isDown)
        {
            if (isEnter)
            {
                sr.sprite = sprite2;
            }
            else
            {
                sr.sprite = sprite3;
            }
        }
        else
        {
            if (isEnter)
            {
                sr.sprite = sprite1;
            }
            else
            {
                sr.sprite = sprite0;
            }
            }
    }

    protected virtual void action()
    {
        Debug.Log("Action");
    }
}
