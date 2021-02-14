using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PanelManager : MonoBehaviour
{
    [SerializeField] int clearCount = 0;
    public int playCount = 0;

    bool firstFlag = false;
    int firstClearCount = 4;

    bool lastFlag = false;

    [SerializeField]PlayableDirector[] director;

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
