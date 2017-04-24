using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRotater : MonoBehaviour {
    public Vector3 rotateValue;
	void Update () {
        transform.Rotate(rotateValue * Time.deltaTime);
	}
}
