using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

    public float Speed = 10f;

	void Update () {
        transform.localPosition += Vector3.down * Speed * Time.deltaTime;
        if (transform.localPosition.y < -10) Destroy(gameObject);
	}
}
