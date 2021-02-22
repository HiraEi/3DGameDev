using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    LightManager m_lightManager;
    PanelManager m_panelManager;

    enum status
    {
        title,
        light,
        panel,
        end,
    }

    void Start()
    {
        status status = status.title;
    }

    void Update()
    {
        
    }
}
