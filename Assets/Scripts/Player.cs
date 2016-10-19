﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static Player instance;

    [SerializeField] private float speed = 15;
    public Rigidbody rb = new Rigidbody();

	void Awake () {
		instance = this;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    void FixedUpdate()
    {
        rb.AddForce(Input.GetAxis("Horizontal") * speed, 0, 0);
        rb.AddForce(0, 0, Input.GetAxis("Vertical") * speed);
    }
}
