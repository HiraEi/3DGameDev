using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LightLook : MonoBehaviour
{
    /// <summary>ライトを見るタイムラインを設定する
    [SerializeField] PlayableDirector m_director = null;

    private void OnTriggerEnter(Collider other)
    {
        m_director.Play();
    }
}
