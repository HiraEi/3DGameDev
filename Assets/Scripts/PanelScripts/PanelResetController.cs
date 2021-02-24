using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelResetController : MonoBehaviour
{
    /// <summary> リセットしたいパネル
    GameObject[] m_objs;
    PanelController m_panel;
    PanelManager m_manager;
    GameObject m_managerObj;

    void Start()
    {
        m_objs = GameObject.FindGameObjectsWithTag("GimmikPanel");
        m_managerObj = GameObject.Find("PanelManager");
        m_manager = m_managerObj.GetComponent<PanelManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        panelReset();
    }

    /// <summary>
    /// 設定されたギミックパネルをすべてOFFにする
    /// </summary>
    void panelReset()
    {
        foreach (var item in m_objs)
        {
            m_panel = item.GetComponent<PanelController>();
            m_panel.m_gimmick = true;
            m_panel.m_audio.enabled = false;
            m_panel.panelSwitch();
            m_panel.m_audio.enabled = true;
        }
        m_manager.m_playCount = 4;
    }
}
