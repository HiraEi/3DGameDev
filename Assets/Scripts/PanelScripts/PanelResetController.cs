using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelResetController : MonoBehaviour
{
    /// <summary> リセットしたいパネル
    GameObject[] objs;
    PanelController panel;
    PanelManager manager;
    GameObject managerObj;

    void Start()
    {
        objs = GameObject.FindGameObjectsWithTag("GimmikPanel");
        managerObj = GameObject.Find("PanelManager");
        manager = managerObj.GetComponent<PanelManager>();
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
        foreach (var item in objs)
        {
            panel = item.GetComponent<PanelController>();
            panel.gimmick = true;
            panel.panelSwitch();
        }

        manager.playCount = 4;
    }
}
