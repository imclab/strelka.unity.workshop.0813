using System.Collections;
using UnityEngine;

public class Enemy06 : MonoBehaviour
{

    public float FireInterval = 3;
    public GameObject BombPrefab;

    private bool dead = false;

    private void Start()
    {
        StartCoroutine("fire");
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (dead) return;

        if (otherCollider.name == "Rocket")
        {
            //Destroy(gameObject);
            Destroy(otherCollider.gameObject);
            dead = true;

            StopCoroutine("fire");

            foreach (var child in gameObject.GetComponentsInChildren<MeshRenderer>())
            {
                child.enabled = false;
            }
            foreach (var child in gameObject.GetComponentsInChildren<Collider>())
            {
                child.enabled = false;
            }

            var time = 0f;
            if (audio != null)
            {
                audio.Play();
                time = audio.clip.length;
            }
            StartCoroutine("die", time);
        }
    }

    private void Update()
    {
        
    }

    private IEnumerator fire()
    {
        yield return new WaitForSeconds(Random.Range(.1f * FireInterval, FireInterval));
        while (true)
        {
            var bomb = Instantiate(BombPrefab) as GameObject;
            bomb.name = "Bomb";
            bomb.transform.position = transform.position;
            yield return new WaitForSeconds(FireInterval);
        }
    }

    private IEnumerator die(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

}