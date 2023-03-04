using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    public delegate void MoodChangeEvent(int mood);
    public event MoodChangeEvent OnMoodChange;
    public delegate void SegmentChangeEvent(int segment);
    public event SegmentChangeEvent OnSegmentChange;

    void Awake()
    {
        Instance = this;
    }

    public void MoodChange(int mood)
    {
        if (OnMoodChange != null) OnMoodChange(mood);
    }

    public void SegmentChange(int segment)
    {
        if (OnSegmentChange != null) OnSegmentChange(segment);
    }
}
