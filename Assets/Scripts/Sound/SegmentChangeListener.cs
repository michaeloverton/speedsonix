using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class SegmentChangeListener : MonoBehaviour
{
    StudioEventEmitter emitter;
    EventInstance instance;
    float previousValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        emitter = GetComponent<StudioEventEmitter>();
        instance = emitter.EventInstance;
    }

    // Update is called once per frame
    void Update()
    {
        float initialValue;
        float segmentChangeValue;
        instance.getParameterByName("SegTrigger", out initialValue, out segmentChangeValue);
        

        if(segmentChangeValue == 1 && previousValue == 0)
        {
            float currentMood;
            instance.getParameterByName("MusicMood", out initialValue, out currentMood);
            AudioManager.Instance.SegmentChange((int)currentMood);
        }

        previousValue = segmentChangeValue;
    }
}
