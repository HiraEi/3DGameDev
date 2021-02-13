using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] GameObject obj = null;
    /// <summary>生成したいオブジェクト
    [SerializeField] GameObject obstaclePrefab = null;
    /// <summary>生成する時間間隔
    [SerializeField] float generatTime = 0f;

    //IEnumerable generat()
    //{
    //    Instantiate(obstaclePrefab, obj.transform.position, Quaternion.identity);

    //    yield return new WaitForSeconds(generatTime);
    //}

    void Update()
    {
        //generat();
        Instantiate(obstaclePrefab, obj.transform.position, Quaternion.identity);
    }
}
