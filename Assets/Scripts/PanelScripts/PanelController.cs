using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public bool m_gimmick = false;
    GameObject m_managerObj;
    PanelManager m_manager;
    MeshRenderer m_mesh;
    [SerializeField] Material off = null;
    [SerializeField] Material on = null;
    public AudioSource m_audio;
    [SerializeField] AudioClip offSE = null;
    [SerializeField] AudioClip onSE = null;

    void Start()
    {
        m_audio = GetComponent<AudioSource>();
        m_managerObj = GameObject.Find("PanelManager");
        m_manager = m_managerObj.GetComponent<PanelManager>();
        m_mesh = GetComponent<MeshRenderer>();
        this.m_mesh.material = off;
    }

    private void OnTriggerEnter(Collider other)
    {
        panelSwitch();
    }

    public void panelSwitch()
    {
        if(!m_gimmick)
        {
            m_gimmick = true;
            this.m_mesh.material = on;
            m_audio.PlayOneShot(onSE);
            m_manager.m_playCount++;
        }
        else
        {
            m_gimmick = false;
            this.m_mesh.material = off;
            m_audio.PlayOneShot(offSE);
            m_manager.m_playCount--;
        }
    }
}
