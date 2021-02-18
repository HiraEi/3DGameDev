using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSetting : MonoBehaviour
{
    [SerializeField] GameObject[] lightObj = null;
    int clearNum;

    void Start()
    {
        clearNum = Random.Range(0, lightObj.Length);
        lightObj[clearNum].SetActive(true);
        //Debug.Log(lightObj[clearNum]);
    }
}
