using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Title Screen")]
    // Only for use in start screen.
    [SerializeField] GameObject blackPanel; // This is an animation that will fade to black.
    [SerializeField] float blackTime = 1.5f;
    [SerializeField] FMODUnity.StudioEventEmitter music;

    void Start()
    {
        SceneVariables.flyMode = false;
    }

    public void GrappleMode()
    {
        StartCoroutine(LoadMainScene());
    }

    public void FlyMode()
    {
        SceneVariables.flyMode = true;
        StartCoroutine(LoadMainScene());
    }

    IEnumerator LoadMainScene()
    {
        // blackPanel.SetActive(true);
        // music.Stop();
        // fire.Stop();

        yield return new WaitForSeconds(blackTime);
        SceneManager.LoadScene("IntroText");
    }

    public void Quit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
}
