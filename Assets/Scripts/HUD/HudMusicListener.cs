using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudMusicListener : MonoBehaviour
{
    [SerializeField] Image panel;
    [SerializeField] float maxPanelAlpha = 1f;
    [SerializeField] float panelFadeTime = 0.5f;
    bool panelIsOn = false;
    float elapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.OnSegmentChange += FlashPanel;
    }

    // Update is called once per frame
    void Update()
    {
        if(panelIsOn)
        {
            float panelAlpha = Mathf.Lerp(maxPanelAlpha, 0, elapsedTime/panelFadeTime);
            panel.color = new Color(panel.color.r, panel.color.g, panel.color.b, panelAlpha);
            elapsedTime += Time.deltaTime;

            if(panelAlpha < 0.01f)
            {
                panel.color = new Color(panel.color.r, panel.color.g, panel.color.b, 0);
                panelIsOn = false;
                elapsedTime = 0f;
            }
        }
    }

    void FlashPanel(int segment)
    {
        panel.color = new Color(panel.color.r, panel.color.g, panel.color.b, maxPanelAlpha);
        panelIsOn = true;
    }
}
