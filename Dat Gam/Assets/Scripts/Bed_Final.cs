﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed_Final : MonoBehaviour {

    bool e;
    bool touching;

    public GameObject sleeping;

    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        touching = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        touching = false;
    }

    void TimeWait()
    {
        SceneManager.LoadScene("test");
    }

    void Update()
    {
        if (Input.GetKeyDown("e")) { e = true; } else { e = false; }

        if (touching && e && !Mvmt.instance.dreaming)
        {
            Instantiate(sleeping, transform.position, transform.rotation);
            Destroy(GameObject.Find("Bob (Player)"));

            Invoke("TimeWait", 2);
        }
    }
}