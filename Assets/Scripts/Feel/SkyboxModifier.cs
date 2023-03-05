using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxModifier : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float baseExposure = 0.6f;
    [SerializeField] float maxExposure = 1.2f;
    [SerializeField] float maxHeight = 4000;
    [SerializeField] Color interludeSkyboxColor;
    Color baseSkyboxColor;
    Color baseFogColor;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox.SetFloat("_Exposure", baseExposure);
        DynamicGI.UpdateEnvironment();
        baseSkyboxColor = RenderSettings.skybox.GetColor("_Tint");
        baseFogColor = RenderSettings.fogColor;

        AudioManager.Instance.OnSegmentChange += ChangeSkyboxColor;
    }

    // Update is called once per frame
    void Update()
    {
        float currentExposure = Utility.Remap(player.position.y, 0, maxHeight, baseExposure, maxExposure);
        RenderSettings.skybox.SetFloat("_Exposure", currentExposure);
        // DynamicGI.UpdateEnvironment();
    }

    void OnDestroy()
    {
        RenderSettings.skybox.SetFloat("_Exposure", baseExposure);
        RenderSettings.skybox.SetColor("_Tint", baseSkyboxColor);
        RenderSettings.fogColor = baseFogColor;
        DynamicGI.UpdateEnvironment();
    }

    void ChangeSkyboxColor(int currentSegment)
    {
        if(currentSegment == 3)
        {
            RenderSettings.skybox.SetColor("_Tint", interludeSkyboxColor);
            RenderSettings.fogColor = interludeSkyboxColor;
            DynamicGI.UpdateEnvironment();
        }
        else
        {
            RenderSettings.skybox.SetColor("_Tint", baseSkyboxColor);
            RenderSettings.fogColor = baseFogColor;
            DynamicGI.UpdateEnvironment();
        }
    }
}
