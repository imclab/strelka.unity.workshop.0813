using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed = 1f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.localPosition += Vector3.left*Speed*Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.localPosition += Vector3.right*Speed*Time.deltaTime;
        }
    }
}