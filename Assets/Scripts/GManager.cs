using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    AudioSource m_audio;
    [SerializeField] AudioClip clip = null;

    private void Start()
    {
        m_audio = GetComponent<AudioSource>();
    }

    public void LightLoad()
    {
        m_audio.PlayOneShot(clip);
        SceneManager.LoadScene(1);
    }

    public void PanelLoad()
    {
        m_audio.PlayOneShot(clip);
        SceneManager.LoadScene(2);
    }

    public void EndLoad()
    {
        m_audio.PlayOneShot(clip);
        SceneManager.LoadScene(3);
    }

    public void TitleLoad()
    {
        m_audio.PlayOneShot(clip);
        SceneManager.LoadScene(0);
    }
}
