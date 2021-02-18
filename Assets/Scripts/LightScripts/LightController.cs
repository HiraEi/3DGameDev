using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    LightManager manager;
    GameObject lightManager;

    void Start()
    {
        lightManager = GameObject.Find("LightManager");
        manager = lightManager.GetComponent<LightManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        manager.gimmikClear = true;
    }
}
