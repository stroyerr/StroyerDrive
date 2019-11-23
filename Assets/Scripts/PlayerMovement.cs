using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody player;
    public float moveSpeed = 50f;
    public float turnSpeed = 20f;
    private bool w = false;
    private bool a = false;
    private bool s = false;
    private bool d = false;
    public float brake = 0.4f;



    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            w = true;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            s = true;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            a = true;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            d = true;
        }

        if (w)
        {
            player.AddRelativeForce(new Vector3(0, 0, moveSpeed * Time.deltaTime), ForceMode.VelocityChange);
            //if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            //{
                w = false;
            //}
        }

        if (s)
        {
            player.AddRelativeForce(new Vector3(0, 0, - moveSpeed * Time.deltaTime), ForceMode.VelocityChange);
           // if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
           // {
                s = false;
           // }
        }

       

        if (a)
        {
            transform.Rotate(new Vector3(0, - turnSpeed * Time.deltaTime, 0));
            a = false;
        }

        if (d)
        {
            transform.Rotate(new Vector3(0, turnSpeed * Time.deltaTime, 0));
            d = false;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            //float x = player.velocity.x;
            //float y = player.velocity.y;
            //float z = player.velocity.z;

            //float newX = x * brake * Time.deltaTime;
            //float newY = y * brake * Time.deltaTime;

            //player.velocity.Set((newX, newY, z));
            //Debug.Log(newX);
            //Debug.Log(newY);

            player.AddRelativeForce(-brake * player.velocity);
   
        }

    }
}
