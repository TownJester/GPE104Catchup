using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Mover mover;

    public ShootBullet ShootBullet;

    public float speed;
    public float turnSpeed;

    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveLeft;
    public KeyCode moveRight;

    public KeyCode Shoot;
    public AudioSource ShootingAudio;
    public AudioSource MoveEffect;

    // This will store the value Shift
    public KeyCode incrementalMovementEnable;

    public KeyCode resetPosition;

    public KeyCode toggleMovement;

    public KeyCode disableSpriteGameObject;

    // Start is called before the first frame update
    void Start()
    {
        mover = GetComponent<Mover>();
        ShootBullet = GetComponent<ShootBullet>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Shoot)){
            ShootingAudio.Play();
            ShootBullet.PewPew();
        }
        if (Input.GetKeyDown(disableSpriteGameObject))
        {
            gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(toggleMovement))
        {
            mover.enabled = !mover.enabled;
        }

        if (Input.GetKeyDown(resetPosition))
        {
            // Reset position
            mover.ResetPosition();
        }

        if (!Input.GetKey(incrementalMovementEnable))
        {
            if (Input.GetKey(moveUp))
            {
                mover.MoveUp(speed);
                MoveEffect.Play();

            }
            if (Input.GetKey(moveDown))
            {
                mover.MoveDown(speed);
                MoveEffect.Play();

            }
            if (Input.GetKey(moveLeft))
            {
                mover.RotateClockwise(turnSpeed);
                 MoveEffect.Play();

            }
            if (Input.GetKey(moveRight))
            {
                mover.RotateCounterclockwise(turnSpeed);
                 MoveEffect.Play();

            }
        }
        else if (Input.GetKey(incrementalMovementEnable))
        {
            if (Input.GetKeyDown(moveUp))
            {
                // Move up 1 meter increment
                mover.MoveUp(1);
            }
            if (Input.GetKeyDown(moveDown))
            {
                // Move down 1 meter increment
                mover.MoveDown(1);
            }/*
            if (Input.GetKeyDown(moveLeft))
            {
                // Move left 1 meter increment
                mover.MoveLeft(1);
            }
            if (Input.GetKeyDown(moveRight))
            {
                // Move right increment
                mover.MoveRight(1);
            }*/
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("The GameObject of the other object is named: " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb2D = collision.gameObject.GetComponent<Rigidbody2D>();

        if (rb2D != null)
        {
            Debug.Log("The X position of the other object's transform is: " + rb2D.name);
        }
        else
        {
            Debug.Log("Rigidbody2D does not exist on GameObject");
        }
    }
}
