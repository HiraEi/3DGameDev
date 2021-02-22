using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasageTextController : MonoBehaviour
{
    Animator m_anim = null;
    AudioSource m_audio = null;
    [SerializeField] Canvas m_canvas = null;
    [SerializeField] Text m_text = null;
    [SerializeField, TextArea(1, 6)] string m_textStr = null;
    [SerializeField] AudioClip m_openSE = null;
    [SerializeField] AudioClip m_closeSE = null;

    void Start()
    {
        m_text.text = m_textStr;
        m_canvas.gameObject.SetActive(false);
        m_anim = GetComponent<Animator>();
        m_audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        m_anim.Play("open");

        if(m_openSE && m_audio)
        {
            m_audio.PlayOneShot(m_closeSE);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        m_anim.Play("close");

        if (m_openSE && m_closeSE)
        {
            m_audio.PlayOneShot(m_closeSE);
        }
    }
}
