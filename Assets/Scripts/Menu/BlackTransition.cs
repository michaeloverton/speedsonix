using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackTransition : MonoBehaviour
{
    [SerializeField] float transitionTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("changeToMenu", transitionTime);
    }

    void changeToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
