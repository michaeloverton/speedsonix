using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempArmAnimation : MonoBehaviour
{
    [SerializeField] GameObject open;
    [SerializeField] GameObject closed;

    void Start()
    {
        Open();
    }

    public void Open()
    {
        open.SetActive(true);
        closed.SetActive(false);
    }

    public void Close()
    {
        open.SetActive(false);
        closed.SetActive(true);
    }
}
