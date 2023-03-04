using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrappleCrosshair : MonoBehaviour
{
    RectTransform rect;
    RawImage crosshairImage;
    Color baseColor;
    [SerializeField] Color onHitColor;
    Vector3 baseScale;
    [SerializeField] float maxScale = 1.25f;
    bool currentlyHitting = false;

    void Start()
    {
        rect = GetComponent<RectTransform>();
        crosshairImage = GetComponent<RawImage>();

        baseColor = crosshairImage.color;
        baseScale = rect.localScale;
    }

    public void CrosshairHit()
    {
        if(!currentlyHitting)
        {
            rect.localScale *= maxScale;
            crosshairImage.color = onHitColor;
            currentlyHitting = true;
        }
    }

    public void CrosshairUnhit()
    {
        if(currentlyHitting)
        {
            rect.localScale = baseScale;
            crosshairImage.color = baseColor;
            currentlyHitting = false;
        }
    }
}
