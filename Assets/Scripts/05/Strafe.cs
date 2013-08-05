using UnityEngine;
using System.Collections;

public class Strafe : MonoBehaviour {

    public float Amplitude = 1;
    public float Frequency = 5;

	void Start () {
	
	}
	
	void Update ()
	{
        transform.localPosition += Vector3.right * Mathf.Sin((Time.time) * Frequency + transform.localPosition.y) * Amplitude;
	}
}
