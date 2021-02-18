using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rockScript : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 pushForce; 
    public Vector3 resetPos;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
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
            // this.transform.position = resetPos;
            // pushForce -= pushForce;
            // Debug.Log("Hit");
            SceneManager.LoadScene("SampleScene");
        }
    }
}
