using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void MainMenu()
    {
        // SceneManager.LoadScene(0);
        Time.timeScale = 1;
        // SceneVariables.paused = false;
        SceneManager.LoadScene(1);

        // StartCoroutine(LoadMainMenu());
    }

    IEnumerator LoadMainMenu()
    {
        // blackPanel.SetActive(true);
        // music.Stop();
        // fire.Stop();

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(1);
    }
}
