using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Asteroid : MonoBehaviour
{
    private SpriteRenderer _sprite;
    public float size = 1.0f;
    public float minSize = 0.5f;
    public float maxSize = 1.5f;
    public float speed = 50.0f;
    public float ttl = 30.0f;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, UnityEngine.Random.value * 360.0f);
        this.transform.localScale = Vector3.one * this.size;

        _rb.mass = this.size;
    }

    public void SetTraj(Vector2 direction)
    {
        _rb.AddForce(direction * this.speed);
        
        Destroy(this.gameObject, this.ttl);
    }
}
