using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LightLook : MonoBehaviour
{
    //[SerializeField] GameObject mainCam = null;
    //[SerializeField] GameObject rightLookCam = null;
    //[SerializeField] GameObject post = null;
    [SerializeField] PlayableDirector director = null;

    private void OnTriggerEnter(Collider other)
    {
        //mainCam.SetActive(false);
        //rightLookCam.SetActive(true);
        director.Play();
        //post.SetActive(true);
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    rightLookCam.SetActive(false);
    //    mainCam.SetActive(true);
    //    post.SetActive(false);
    //}
}
