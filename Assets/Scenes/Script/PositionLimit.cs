using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLimit : MonoBehaviour {

    public float xMax, yMax;
    public float xMin, yMin;

    Transform transformPos;

	// Use this for initialization
	void Start () {
        transformPos = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = transformPos.position.x;
        float y = transformPos.position.y;

        if (x > xMax) transformPos.position = new Vector3(xMax, y);
        else if (x < xMin) transformPos.position = new Vector3(xMin, y);

        if (y > yMax) transformPos.position = new Vector3(x, yMax);
        else if (y < yMin) transformPos.position = new Vector3(x, yMin);
    }
}
