using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Transform tf;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void
        Update()
    {
        
    }

    public void MoveUp(float speedInput)
    {
        // Move up every frame draw by adding something to the Y of our position
        //tf.position = tf.position + (tf.right * speedInput);
        rb2D.AddForce(tf.right * speedInput);
    }

    public void MoveDown(float speedInput)
    {
        //tf.position = tf.position + (tf.right * -speedInput);
        rb2D.AddForce(tf.right * -speedInput);
    }

    public void RotateClockwise(float turnSpeed)
    {
        tf.Rotate(0, 0, turnSpeed);
    }

    public void RotateCounterclockwise(float turnSpeed)
    {
        tf.Rotate(0, 0, -turnSpeed);
    }

    public void ResetPosition()
    {
        // Resets our position back to the world's origin
        tf.position = Vector3.zero;
    }
}
