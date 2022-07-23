using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ElevatorController : MonoBehaviour
{
    /// <summary>エレベーターの移動先</summary>
    [SerializeField] Transform m_target = null;
    /// <summary>エレベーターの起動スイッチ</summary>
    [SerializeField] Collider m_trigger = null;
    /// <summary>エレベーターの初期位置</summary>
    Vector3 startPosition;

    [SerializeField] bool m_blueElevator = false;

    GameObject m_lightManager;
    LightManager m_manager;

    void Start()
    {
        startPosition = this.transform.position;

        m_lightManager = GameObject.Find("LightManager");
        m_manager = m_lightManager.GetComponent<LightManager>();
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

    void Elevator()
    {
        m_trigger.enabled = false;
        Sequence seq = DOTween.Sequence();
        seq.AppendInterval(0.5f)
            .Append(this.transform.DOMove(m_target.position, 2f))
            .AppendInterval(1.5f)
            .Append(this.transform.DOMove(startPosition, 2f))
            .AppendInterval(3f)
            .OnComplete(() => m_trigger.enabled = true);
    }
}
