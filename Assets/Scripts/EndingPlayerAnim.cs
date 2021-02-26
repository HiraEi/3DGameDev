using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingPlayerAnim : MonoBehaviour
{
    Animator m_anim;

    void Start()
    {
        m_anim = GetComponent<Animator>();
        m_anim.SetBool("play",true);
    }
}
