using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    public void LightLoad()
    {
        SceneManager.LoadScene(1);
    }

    public void PanelLoad()
    {
        SceneManager.LoadScene(2);
    }

    public void EndLoad()
    {
        SceneManager.LoadScene(3);
    }
}
