﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;
    public float damage;

    private AudioSource audioSource;

    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        InvokeRepeating("Fire", delay, fireRate);
    }

    void Fire()
    {
        Instantiate(shot, shotSpawn.position, shot.GetComponent<Transform>().rotation);
        //audioSource.Play();
    }

}