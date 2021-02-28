using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{

    public GameObject rock;
    private Vector3 rockPos;

    public int score;

    public float time;
    public float maxTime;

    public float deductT;
    public float maxDeductT;

    public rockScript rocky;

    public Text text;

    void Start()
    {
        score = PlayerPrefs.GetInt("Score", rocky.oldValue);
        changeTime();
    }

    // Update is called once per frame
    void Update()
    {
        //rock.GetComponent<transform.position>();
        rockPos = new Vector3(rock.transform.position.x, rock.transform.position.y, -2);
        this.transform.position = rockPos;


        if (rocky.rb.velocity.x > 0)
        {
            time += Time.deltaTime;
            if (time >= maxTime)
            {
                time = 0;
                score += 1;
                PlayerPrefs.SetInt("Score", score);
                changeTime();
            }
        }

        if (rocky.rb.velocity.x < 0){
            deductT += Time.deltaTime;
            if (deductT >= maxDeductT){
                deductT = 0;
                score -= 1;
                PlayerPrefs.SetInt("Score", score);
                changeDeduct();
            }
        }

        text.text = "Score:" + score;
    }

    void changeTime(){
        maxTime = Random.Range(3, 5);
    }

    void changeDeduct(){
        maxDeductT = Random.Range(1, 3);
    }
}
