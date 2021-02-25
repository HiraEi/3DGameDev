using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    GameObject m_lightManager;
    LightManager m_manager;
    AudioSource m_audio;
    [SerializeField] AudioClip clearSE = null;
    
    void Start()
    {
        m_lightManager = GameObject.Find("LightManager");
        m_manager = m_lightManager.GetComponent<LightManager>();
        m_audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        m_manager.m_gimmikClear = true;
        m_audio.PlayOneShot(clearSE);
    }
}
