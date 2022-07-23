using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    /// <summary>ライトマネージャー</summary>
    LightManager m_manager;
    AudioSource m_audio;
    /// <summary>クリアSE</summary>
    [SerializeField] AudioClip m_clearSE = null;
    
    void Start()
    {
        m_manager = GameObject.Find("LightManager").GetComponent<LightManager>();
        m_audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        m_manager.m_gimmikClear = true;
        m_audio.PlayOneShot(m_clearSE);
    }
}
