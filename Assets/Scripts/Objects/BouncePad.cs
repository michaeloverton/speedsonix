using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    public float bounceForce = 200f;
    float cooldownTime = 1f;
    bool cooldown = false;

    void OnCollisionEnter(Collision collision) {
        if(collision.rigidbody != null && !cooldown) {
            collision.rigidbody.velocity = Vector3.zero;
            collision.rigidbody.AddForce(transform.up * bounceForce, ForceMode.Impulse);
            cooldown = true;
            Invoke("resetCooldown", cooldownTime);
        }
    }

    void resetCooldown()
    {
        cooldown = false;
    }
}
