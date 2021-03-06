﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rockScript : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 pushForce; 
    public Vector3 resetPos;

    public float weight;

    public playerScript play;
    public int oldValue;

    public GameObject checkpoint;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        oldValue = PlayerPrefs.GetInt("Old");
        randomizeWeight();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown){
            rb.AddForce(pushForce);
        }
    }
    
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Reset"){
            //this.transform.position = resetPos;
            //pushForce -= pushForce;
            Debug.Log("Hit");
            oldValue = play.score;
            PlayerPrefs.SetInt("Old", oldValue);
            //SceneManager.LoadScene("SampleScene");
            transform.position = checkpoint.transform.position;
            transform.rotation = checkpoint.transform.rotation;
            Physics.SyncTransforms();
            randomizeWeight();
        }
    }

    void randomizeWeight(){
        weight = Random.Range(0.2f, 0.4f);

        rb.mass = weight;
    }
}
