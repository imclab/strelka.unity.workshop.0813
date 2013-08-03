using System.Collections;
using UnityEngine;

public class Enemy05 : MonoBehaviour
{

    public float FireInterval = 3;
    public GameObject BombPrefab;

    private void Start()
    {
        StartCoroutine(fire());
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.name == "Rocket")
        {
            Destroy(gameObject);
            Destroy(otherCollider.gameObject);
        }
    }

    private void Update()
    { }

    private IEnumerator fire()
    {
        yield return new WaitForSeconds(Random.Range(.1f*FireInterval, FireInterval));
        while (true)
        {
            var bomb = Instantiate(BombPrefab) as GameObject;
            bomb.name = "Bomb";
            bomb.transform.position = transform.position;
            yield return new WaitForSeconds(FireInterval);
        }
    }

}