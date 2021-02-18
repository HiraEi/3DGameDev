using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    public bool gimmikClear = false;
    public int clearNum;

    private void Update()
    {
        if(gimmikClear)
        {
            Debug.Log("クリア");
        }
    }
}
