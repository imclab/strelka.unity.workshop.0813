using UnityEngine;
using System.Collections;

public class EnemySpawner04 : MonoBehaviour
{
    public GameObject EnemyPrefab;

    public int Rows = 3;
    public int Columns = 10;
    public float RowPadding = 1;
    public float ColumnPadding = 1;

    public float MoveInteval = 2f;
    public float MoveAmount = .2f;

    private void Start()
    {
        for (var i = 0; i < Rows; i++)
        {
            for (var j = 0; j < Columns; j++)
            {
                var enemy = Instantiate(EnemyPrefab) as GameObject;
                enemy.transform.parent = transform;
                enemy.transform.localPosition = Vector3.down*i*RowPadding + Vector3.right*j*ColumnPadding;
            }
        }

        MoveInteval /= Mathf.Sqrt((FindObjectOfType(typeof(Levels04)) as Levels04).Level);

        StartCoroutine(move());
    }

    private IEnumerator move()
    {
        while (true)
        {
            yield return new WaitForSeconds(MoveInteval);
            foreach (Transform enemy in transform)
            {
                enemy.localPosition += Vector3.down*MoveAmount;
            }
        }
    }

}