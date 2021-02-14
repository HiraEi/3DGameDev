using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSetting : MonoBehaviour
{
    [SerializeField] GameObject[] lightObj = null;
    int clearNum;
    Light lightComp;

    void Start()
    {
        clearNum = Random.Range(0, lightObj.Length);
        lightComp = lightObj[clearNum].GetComponent<Light>();
        lightComp.enabled = true;
    }
}
