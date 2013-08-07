using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.name == "Bomb")
        {
            Destroy(gameObject);
            Destroy(otherCollider.gameObject);
        }
    }

}