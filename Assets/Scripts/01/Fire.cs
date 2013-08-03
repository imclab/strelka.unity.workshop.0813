using UnityEngine;

public class Fire : MonoBehaviour
{
    public Vector3 SpawnOffset = Vector3.zero;
    public GameObject RocketPrefab;

    private void Start()
    {}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            doFire();
        }
    }

    private void doFire()
    {
        var rocket = Instantiate(RocketPrefab) as GameObject;
        rocket.name = "Rocket";
        rocket.transform.position = transform.position + SpawnOffset;
    }
}