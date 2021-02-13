using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    /// <summary>
    /// 生成したいオブジェクト
    /// </summary>
    [SerializeField] GameObject obstaclePrefab = null;

    /// <summary>
    /// 生成する時間間隔
    /// </summary>
    [SerializeField] float generatTime = 0f;

    IEnumerable generat()
    {
        Instantiate(obstaclePrefab, this.transform);

        yield return new WaitForSeconds(generatTime);
    }
}
