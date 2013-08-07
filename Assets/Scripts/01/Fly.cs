using UnityEngine;

public class Fly : MonoBehaviour
{

    public float Speed = 10;

    private void Update()
    {
        transform.localPosition += Vector3.up*Speed*Time.deltaTime;
        if (transform.localPosition.y > 10) Destroy(gameObject);
    }
}