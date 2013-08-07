using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour
{
    public float Multiplier = 1;

    private void Update()
    {
        var player = GameObject.Find("Player");
        if (player == null) return;
        transform.localRotation = Quaternion.Euler(0, player.transform.localPosition.x * Multiplier, 0);
    }
}