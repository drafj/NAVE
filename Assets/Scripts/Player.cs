using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float velocity;
    private float direction;
    private Rigidbody2D rgbd;

    private void Awake()
    {
        rgbd = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    void KeyboardMoviment()
    {
        direction = Input.GetAxis("Horizontal");
        direction = direction * velocity * Time.deltaTime;

        rgbd.velocity += new Vector2(direction, 0);
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        KeyboardMoviment();
    }
}
