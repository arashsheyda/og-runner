using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    public List<GameObject> obstacle;
    private int totalObstables;
    
    public ObstacleInfo obstacleInfo;
    
    [Tooltip("Eğer GameManager'daki Bullet Info verilerini kullanmak istemiyorsanız true olarak işaretleyin.")]
    public bool useMyVales;
    private float waitTime;
    void Start()
    {
        totalObstables = obstacle.Count;
        waitTime = obstacleInfo.waitTimeFirstShot.GetRandomValue;
        StartCoroutine(CreateObstacle());
    }
    public void Create()
    {
        Instantiate(obstacle[Random.Range(0, totalObstables)], transform.position, Quaternion.identity);
        // PoolManager.instance?.PullFromPool(bullet, createPoint.position);
    }

    IEnumerator CreateObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Create();
            waitTime = obstacleInfo.randomTime.GetRandomValue;
        }
    }
}
