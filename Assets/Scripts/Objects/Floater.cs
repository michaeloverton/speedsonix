using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    [SerializeField] float maxExtent;
    [SerializeField] float timeScaleFactor = 0.25f;
    float offset;
    float initialYPosition;

    // Start is called before the first frame update
    void Start()
    {
        offset = Random.Range(0, 2* Mathf.PI);
        initialYPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            initialYPosition + (maxExtent * Mathf.Sin(offset + (Time.time * timeScaleFactor))),
            transform.position.z
        );
    }
}
