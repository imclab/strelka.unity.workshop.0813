using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Start()
    {}

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.name == "Rocket")
        {
            Destroy(gameObject);
            Destroy(otherCollider.gameObject);
        }
    }

    private void Update()
    {}
}