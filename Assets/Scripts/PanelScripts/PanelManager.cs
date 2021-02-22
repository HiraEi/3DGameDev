using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PanelManager : MonoBehaviour
{
    /// <summary> クリア枚数の設定
    [SerializeField] int m_clearCount = 0;
    /// <summary>プレイヤーが踏んだパネルの枚数
    public int m_playCount = 0;
    /// <summary> 最初の扉のクリア枚数設定
    int m_firstClearCount = 4;
    /// <summary> 最初の扉のクリアフラグ
    bool m_firstFlag = false;
    /// <summary> 最後の扉のクリアフラグ
    bool m_lastFlag = false;
    /// <summary>　扉のクリア演出の設定
    [SerializeField] PlayableDirector[] m_director = null;

    void Update()
    {
        if(m_playCount == m_firstClearCount && !m_firstFlag)
        {
            m_firstFlag = true;
            m_director[0].Play();
        }

        if(m_playCount == m_clearCount && !m_lastFlag)
        {
            m_lastFlag = true;
            m_director[1].Play();
        }
    }
}
