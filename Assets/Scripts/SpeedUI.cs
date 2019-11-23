using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedUI : MonoBehaviour
{

    public Transform player;
    public Rigidbody rb;
    public Text kph;
  //  public float speed = rb.velocity.magnitude;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        kph.text = rb.velocity.magnitude + "kph";
    }
}
