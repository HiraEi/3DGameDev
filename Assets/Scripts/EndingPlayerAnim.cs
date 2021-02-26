using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingPlayerAnim : MonoBehaviour
{
    Animator m_anim;
    bool play = false;

    void Start()
    {
        m_anim = GetComponent<Animator>();
        m_anim.SetBool("play",true);
        Debug.Log(play);
    }
}
