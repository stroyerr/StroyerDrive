using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{

    public Transform player;
    public Vector3 originalPos;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        originalPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) || player.transform.position.y < 0)
    {
        player.transform.position = originalPos;
            rb.velocity = Vector3.zero;
    }
    }
}
