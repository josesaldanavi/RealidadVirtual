﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationRandom: MonoBehaviour
{
    public float rotationVelocity;
    public float health = 50f;
    private AudioSource audioExplosion;
    private Rigidbody rgbd;
    private Transform roca;
    public  GameObject Asteroide;
    public GameObject point;
    public GameController pointScript;

    private void Awake()
    {
        //rgbd = GetComponent<Rigidbody>();
 
        roca = GetComponent<Transform>();
        //audioExplosion = GetComponent<AudioSource>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        point = GameObject.FindGameObjectWithTag("GameController");
        pointScript = point.GetComponent<GameController>();
        rgbd = Asteroide.GetComponent<Rigidbody>();
        rgbd.angularVelocity = Random.insideUnitCircle * rotationVelocity;


        

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            //audioExplosion.Play();
            Destroy(gameObject);
            pointScript.score += 1;
        }
    }
}
