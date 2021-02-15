using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PanelManager : MonoBehaviour
{
    /// <summary> クリア枚数の設定
    [SerializeField] int clearCount = 0;
    /// <summary>プレイヤーが踏んだパネルの枚数
    public int playCount = 0;
    /// <summary> 最初の扉のクリア枚数設定
    int firstClearCount = 4;
    /// <summary> 最初の扉のクリアフラグ
    bool firstFlag = false;
    /// <summary> 最後の扉のクリアフラグ
    bool lastFlag = false;
    /// <summary>　扉のクリア演出の設定
    [SerializeField] PlayableDirector[] director = null;

    void Update()
    {
        if(playCount == firstClearCount && !firstFlag)
        {
            firstFlag = true;
            director[0].Play();
        }

        if(playCount == clearCount && !lastFlag)
        {
            lastFlag = true;
            director[1].Play();
        }
    }
}
