using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public bool gimmick = false;
    GameObject managerObj;
    PanelManager manager;
    MeshRenderer mesh;
    [SerializeField] Material off = null;
    [SerializeField] Material on = null;

    void Start()
    {
        managerObj = GameObject.Find("PanelManager");
        manager = managerObj.GetComponent<PanelManager>();
        mesh = GetComponent<MeshRenderer>();
        this.mesh.material = off;
    }

    private void OnTriggerEnter(Collider other)
    {
        panelSwitch();
    }

    public void panelSwitch()
    {
        if(!gimmick)
        {
            gimmick = true;
            this.mesh.material = on;
            manager.playCount++;
        }
        else
        {
            gimmick = false;
            this.mesh.material = off;
            manager.playCount--;
        }
    }
}
