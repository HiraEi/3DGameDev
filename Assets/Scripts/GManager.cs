using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    void LightLoad()
    {
        SceneManager.LoadScene(1);
    }

    void PanelLoad()
    {
        SceneManager.LoadScene(2);
    }

    void EndLoad()
    {
        SceneManager.LoadScene(3);
    }
}
