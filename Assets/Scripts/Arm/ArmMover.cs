using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMover : MonoBehaviour
{
    [SerializeField] float moveTime;
    [SerializeField] float maxMove;
    float currentMove = 0f;
    float initialXPos;

    void Start()
    {
        initialXPos = transform.position.x;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            currentMove = Mathf.Lerp(currentMove, maxMove, moveTime * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            currentMove = Mathf.Lerp(currentMove, -maxMove, moveTime * Time.deltaTime);
        }
        else
        {
            currentMove = Mathf.Lerp(currentMove, 0, moveTime * Time.deltaTime);
        }

        transform.localPosition = new Vector3(initialXPos + currentMove, transform.localPosition.y, transform.localPosition.z);
    }
}
