using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroTextManager : MonoBehaviour
{
    [SerializeField] float sceneTime = 3f;
    float elapsedTime = 0f;

    // Update is called once per frame
    void Update()
    {
        if(elapsedTime > sceneTime)
        {
            SceneManager.LoadScene("Final");
        }
        
        elapsedTime += Time.deltaTime;
    }
}
