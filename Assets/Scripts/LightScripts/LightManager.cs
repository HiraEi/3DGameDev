using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    public bool gimmikClear = false;

    private void Update()
    {
        if(gimmikClear)
        {
            Debug.Log("クリア");
        }
    }
}
