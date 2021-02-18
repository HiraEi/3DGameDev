using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSetting : MonoBehaviour
{
    /// <summary>ライトのオブジェクトを設定する
    [SerializeField] GameObject[] lightObj = null;
    /// <summary>セットされる正解のライトの番号
    int setNum;
    /// <summary>コライダーのオブジェクトを設定する
    /// 設定時、ライトのオブジェクトと同順に設定すること
    [SerializeField] GameObject[] clearCollider = null;

    void Start()
    { 
        setNum = Random.Range(0, lightObj.Length);
        lightObj[setNum].SetActive(true);
        clearCollider[setNum].SetActive(true);
    }
}
