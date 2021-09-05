﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float InitialForce;
    private Vector2 trajectoryOrigin;
    public Vector2 TrajectoryOrigin
    {
        get { return trajectoryOrigin; }
    }
    // Start is called before the first frame update
    public void ResetBall()
    {
        transform.position = Vector2.zero;
        rigidBody2D.velocity = Vector2.zero;

    }
    void PushBall()
    {
        float randomDirection = Random.Range(0, 360);
        float angle = randomDirection * Mathf.PI/180;
        float yForce = Mathf.Sin(angle) * InitialForce;
        float xForce = Mathf.Cos(angle) * InitialForce;
        if (randomDirection < 1.0f)
        {
            rigidBody2D.AddForce(new Vector2(-xForce, yForce));
        }
        else
        {
            rigidBody2D.AddForce(new Vector2(-xForce, yForce));
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        trajectoryOrigin = transform.position;
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("PushBall", 2);
    }
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        trajectoryOrigin = transform.position;
        RestartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
