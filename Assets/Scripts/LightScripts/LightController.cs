using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    GameObject m_lightManager;
    LightManager m_manager;
    
    void Start()
    {
        m_lightManager = GameObject.Find("LightManager");
        m_manager = m_lightManager.GetComponent<LightManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        m_manager.m_gimmikClear = true;
    }
}
