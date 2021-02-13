using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelResetController : MonoBehaviour
{
    GameObject[] objs;
    PanelController panel;
 
    void Start()
    {
        objs = GameObject.FindGameObjectsWithTag("GimmikPanel");
    }

    private void OnTriggerEnter(Collider other)
    {
        panelReset();
    }

    /// <summary>
    /// タグがついたギミックパネルをすべてOFFにする
    /// </summary>
    void panelReset()
    {
        foreach (var item in objs)
        {
            panel = item.GetComponent<PanelController>();
            panel.gimmick = true;
            panel.panelSwitch();
        }

        panel.manager.count = 4;
    }
}
