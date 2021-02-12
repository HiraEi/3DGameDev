using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] int clearCount = 0;

    public int count = 0;

    void Update()
    {
        if (count == clearCount)
        {
            Debug.Log("クリア");
        }
    }
}
