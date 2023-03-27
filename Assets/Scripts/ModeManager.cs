using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
{
    [SerializeField] GameObject playerContainer;
    [SerializeField] GameObject overlayCamera;
    [SerializeField] GameObject flyCamera;

    // Start is called before the first frame update
    void Start()
    {
        // Grapple player is by default enabled.
        // Only need to disable if fly mode is active.
        if(SceneVariables.flyMode)
        {
            flyCamera.SetActive(true);
            playerContainer.SetActive(false);
            overlayCamera.SetActive(false);
        }
    }
}
