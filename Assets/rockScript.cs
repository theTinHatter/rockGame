using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rockScript : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 pushForce; 
    public Vector3 resetPos;

    public float weight;

    public playerScript play;
    public int oldValue;
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
            this.transform.position = resetPos;
            pushForce -= pushForce;
            Debug.Log("Hit");
            oldValue = play.score;
            PlayerPrefs.SetInt("Old", oldValue);
            SceneManager.LoadScene("SampleScene");
        }
    }

    void randomizeWeight(){
        weight = Random.Range(0.5f, 1f);

        rb.mass = weight;
    }
}
