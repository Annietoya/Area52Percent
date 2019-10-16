﻿using UnityEngine;

public class HeightChange : MonoBehaviour
{
    private Rigidbody _rb;
    public float speed = 10f;
    public float maxHeight = 15f;
    public float minHeight = 10f;

    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Z)  && this.transform.position.y < maxHeight)
        {
            _rb.AddForce(Vector3.up * speed);            
        }
        if (Input.GetKey(KeyCode.C) && this.transform.position.y > minHeight)
        {
            _rb.AddForce(Vector3.down * speed);
        }
    }
}
