using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDataText : MonoBehaviour
{
    [SerializeField] GameObject player;
    Rigidbody rb;
    TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody>();
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText(
            "vel:" + Vector3.Magnitude(rb.velocity) + "m/s" + "\n" +
            "pos_x:" + player.transform.position.x + "\n" +
            "pos_y:" + player.transform.position.y + "\n" +
            "pos_z:" + player.transform.position.z + "\n"
        );
    }
}
