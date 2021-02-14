using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] int clearCount = 0;
    public int playCount = 0;

    bool firstFlag = false;
    int firstClearCount = 4;

    bool lastFlag = false;

    void Update()
    {
        //if (clearCount == playCount)
        //{
        //    Debug.Log("クリア");
        //}

        if(playCount == firstClearCount)
        {
            firstFlag = true;
        }

        if(playCount == clearCount)
        {
            lastFlag = true;
        }
    }
}
