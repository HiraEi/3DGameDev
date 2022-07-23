using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>エレベータークラス</summary>
public class ElevatorController : MonoBehaviour
{
    /// <summary>エレベーターの移動先</summary>
    [SerializeField] Transform m_target = null;
    /// <summary>エレベーターの起動スイッチ</summary>
    [SerializeField] Collider m_trigger = null;
    /// <summary>エレベーターの初期位置</summary>
    Vector3 m_startPosition;
    /// <summary>エレベーターが動くか否か</summary>
    [SerializeField] bool m_blueElevator = false;
    /// <summary>ライトマネージャー</summary>
    LightManager m_manager;

    void Start()
    {
        m_startPosition = this.transform.position;
        m_manager = GameObject.Find("LightManager").GetComponent<LightManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (m_blueElevator || m_manager.m_gimmikClear)
        {
            other.gameObject.transform.SetParent(transform);
            Elevator();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        collision.gameObject.transform.SetParent(null);
    }

    /// <summary>
    /// エレベーターの移動
    /// </summary>
    void Elevator()
    {
        m_trigger.enabled = false;
        Sequence seq = DOTween.Sequence();
        seq.AppendInterval(0.5f)
            .Append(this.transform.DOMove(m_target.position, 2f))
            .AppendInterval(1.5f)
            .Append(this.transform.DOMove(m_startPosition, 2f))
            .AppendInterval(3f)
            .OnComplete(() => m_trigger.enabled = true);
    }
}
