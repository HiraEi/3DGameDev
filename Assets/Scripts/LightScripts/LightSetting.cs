using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSetting : MonoBehaviour
{
    [SerializeField] GameObject[] lightObj = null;
    int setNum;
    GameObject lightManager;
    LightManager manager;
    [SerializeField] GameObject[] clearCollider = null;

    void Start()
    { 
        lightManager = GameObject.Find("LightManager");
        manager = lightManager.GetComponent<LightManager>();

        setNum = Random.Range(0, lightObj.Length);
        lightObj[setNum].SetActive(true);
        clearCollider[setNum].SetActive(true);
        manager.clearNum = this.setNum;

        //Debug.Log(manager.clearNum);
        //Debug.Log(lightObj[clearNum]);
        
    }
}
