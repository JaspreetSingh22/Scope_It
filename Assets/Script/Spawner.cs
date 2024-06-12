using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform Point1;
    public Transform Point2;
    [SerializeField] GameObject Enemy;
    [SerializeField] float SpawnTimer;
    [SerializeField] float CurrentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(CurrentTime > SpawnTimer)
        {
            float randomX = Random.Range(Point1.transform.position.x, Point2.transform.position.x);
            float randomY = Random.Range(Point1.transform.position.y, Point2.transform.position.y);
            float randomZ = Random.Range(Point1.transform.position.z, Point2.transform.position.z);

        Vector3 randomPos = new Vector3(randomX, randomY, randomZ);
            Instantiate(Enemy ,randomPos , Quaternion.identity);
            CurrentTime = 0;
        }

        CurrentTime += Time.deltaTime;
    }
}
