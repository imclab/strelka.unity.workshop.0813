using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.name == "Bomb")
        {
            Destroy(gameObject);
            Destroy(otherCollider.gameObject);
        }
    }

    private void Start()
    {}
}