using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmAnimator : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PullBack()
    {
        anim.SetTrigger("PullBack");
        anim.SetBool("TEST", true);
    }

    public void Return()
    {
        anim.SetTrigger("Return");
        anim.SetBool("TEST", false);
    }
}
