using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float XSpeed = 1;
    public float YSpeed = 1;
    public float ZSpeed = 1;
    public float SpeedVariation = .3f;

    private Vector3 speed;

    private void Start()
    {
        speed = new Vector3(XSpeed*(1 + Random.Range(-SpeedVariation, SpeedVariation)), YSpeed*(1 + Random.Range(-SpeedVariation, SpeedVariation)), ZSpeed*(1 + Random.Range(-SpeedVariation, SpeedVariation)));
    }

    private void Update()
    {
        transform.Rotate(speed * Time.deltaTime);
    }
}