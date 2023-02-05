using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WASD : MonoBehaviour
{
    
    Rigidbody _rb;

    public float forceAmount = 5;

    public static WASD Instance;
    
    // Start is called before the first frame update

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(0, 0, forceAmount);
            //Debug.Log("UP");
        }

        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(0, 0, -forceAmount);
            //Debug.Log("Down");
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(-forceAmount, 0, 0);
            //Debug.Log("left");
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(forceAmount, 0, 0);
            //Debug.Log("right");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Hit Spacebar");
            _rb.AddForce(0, forceAmount, 0);
        }
    }
}
