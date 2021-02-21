using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ElevatorController : MonoBehaviour
{
    /// <summary>エレベーターの移動先
    [SerializeField] Transform target = null;
    /// <summary>エレベーターの起動スイッチ
    [SerializeField] Collider trigger = null;
    /// <summary>エレベーターの初期位置
    Vector3 startPosition;

    [SerializeField] bool blueElevator = false;

    GameObject lightManager;
    LightManager manager;

    void Start()
    {
        startPosition = this.transform.position;

        lightManager = GameObject.Find("LightManager");
        manager = lightManager.GetComponent<LightManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.SetParent(this.transform);
        if (blueElevator || manager.gimmikClear)
        {
            other.transform.SetParent(this.transform);
            Elevator();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        //transform.DetachChildren();
        transform.parent = null;
    }

    void Elevator()
    {
        trigger.enabled = false;
        Sequence seq = DOTween.Sequence();
        seq.Append(this.transform.DOMove(target.position, 2f))
            .AppendInterval(3f)
            .Append(this.transform.DOMove(startPosition, 2f))
            .AppendInterval(3f)
            .OnComplete(() => trigger.enabled = true);
        //seq.Play();
    }
}
