using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuListener : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        PauseManager.Instance.OnPauseChange += OnPauseChange;
    }

    void OnPauseChange()
    {
        if(SceneVariables.paused)
        {
            pauseMenu.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(false);
        }
    }
}
