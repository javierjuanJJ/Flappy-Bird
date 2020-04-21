using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public int columnPoolSize = 5;

    public GameObject columnPrefab;
    public GameObject bird;
    private GameObject[] columns;
    private Vector2 objectPoolPosition = new Vector2(-14,0);
    public float spaw;
    private float timeSince;
    
    public float columnMin = -2.9f;
    public float columnMax = 1.4f;
    private float spawnX = 10f;
    private int currentColumn;
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i] = Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSince += Time.deltaTime;
        if (!GameController.instance.gameOver && timeSince >= spaw)
        {
            timeSince = 0;
            columns[currentColumn].transform.position = new Vector2(spawnX,Random.Range(columnMin, columnMax));
            spawnX += spawnX;
            currentColumn++;
            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }
        }
    }
}
