using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour
{
    public GameObject ExplosionPrefab;

    private bool quitting = false;

    private void OnDestroy()
    {
        if (quitting || Application.isLoadingLevel) return;
        var explosion = Instantiate(ExplosionPrefab) as GameObject;
        explosion.name = "Explosion";
        explosion.transform.position = transform.position;
    }

    private void OnApplicationQuit()
    {
        quitting = true;
    }

}