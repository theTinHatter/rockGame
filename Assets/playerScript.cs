using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    public GameObject rock;
    private Vector3 rockPos;

    public int score;

    public float time;
    public float maxTime;

    public rockScript rocky;

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

        time += Time.deltaTime;

        if (time >= maxTime){
            time = 0;
            score += 1;
            PlayerPrefs.SetInt("Score", score);
            changeTime();
        }
    }

    void changeTime(){
        maxTime = Random.Range(3, 5);
    }
}
