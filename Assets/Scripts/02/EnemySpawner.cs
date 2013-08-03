using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;

    public int Rows = 3;
    public int Columns = 10;
    public float RowPadding = 1;
    public float ColumnPadding = 1;

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
    }

    private void Update()
    {}
}