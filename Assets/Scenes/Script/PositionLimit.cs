using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLimit : MonoBehaviour {

    public float xMax, yMax;
    public float xMin, yMin;

    Transform transform;

	// Use this for initialization
	void Start () {
        transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = transform.position.x;
        float y = transform.position.y;

        if (x > xMax) transform.position = new Vector3(xMax, y);
        else if (x < xMin) transform.position = new Vector3(xMin, y);

        if (y > yMax) transform.position = new Vector3(x, yMax);
        else if (y < yMin) transform.position = new Vector3(x, yMin);
    }
}
