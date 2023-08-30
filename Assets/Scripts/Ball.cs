using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidBody2D { get; private set; }
    public Vector2 direction { get; private set; }
    public float speed = 500f;

    private void Awake()
    {
        this.rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Invoke(nameof(SetRandomTrajectory), 1f);
    }

    public void ResetBall()
    {
        this.transform.position = Vector2.zero;
        this.rigidBody2D.velocity = Vector2.zero;

        Invoke(nameof(SetRandomTrajectory), 1f);
    }    

    private void SetRandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1f, 1f);
        force.y = -1f;

        this.rigidBody2D.AddForce(force.normalized * this.speed);
    }

}
