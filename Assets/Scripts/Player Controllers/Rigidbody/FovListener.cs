using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FovListener : MonoBehaviour
{
    Camera cam;
    float baseFOV;
    [SerializeField] float maxFOV = 120;
    [SerializeField] float returnTime = 0.5f;
    bool triggered = false;
    float elapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        baseFOV = cam.fieldOfView;

        AudioManager.Instance.OnSegmentChange += BoostFOV;
    }

    // Update is called once per frame
    void Update()
    {
        if(triggered)
        {
            float currentFOV = Mathf.Lerp(maxFOV, baseFOV, elapsedTime/returnTime);
            cam.fieldOfView = currentFOV;
            elapsedTime += Time.deltaTime;

            if(Mathf.Abs(currentFOV - baseFOV) < 0.01f)
            {
                cam.fieldOfView = baseFOV;
                triggered = false;
                elapsedTime = 0f;
            }
        }
    }

    void BoostFOV(int currentSegment)
    {
        cam.fieldOfView = maxFOV;
        triggered = true;
    }
}
