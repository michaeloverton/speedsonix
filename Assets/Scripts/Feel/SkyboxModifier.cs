using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxModifier : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float baseExposure = 0.6f;
    [SerializeField] float maxExposure = 1.2f;
    [SerializeField] float maxHeight = 4000;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox.SetFloat("_Exposure", baseExposure);
        DynamicGI.UpdateEnvironment();
    }

    // Update is called once per frame
    void Update()
    {
        float currentExposure = Utility.Remap(player.position.y, 0, maxHeight, baseExposure, maxExposure);
        RenderSettings.skybox.SetFloat("_Exposure", currentExposure);
        DynamicGI.UpdateEnvironment();
    }

    void OnDestroy()
    {
        RenderSettings.skybox.SetFloat("_Exposure", baseExposure);
        DynamicGI.UpdateEnvironment();
    }
}
