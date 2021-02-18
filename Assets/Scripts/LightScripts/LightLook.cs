using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LightLook : MonoBehaviour
{
    /// <summary>
    /// ライトを見るタイムラインを設定する
    /// </summary>
    [SerializeField] PlayableDirector director = null;

    private void OnTriggerEnter(Collider other)
    {
        director.Play();
    }
}
