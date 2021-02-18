using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    public GameObject rock;
    private Vector3 rockPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rock.GetComponent<transform.position>();
        rockPos = new Vector3(rock.transform.position.x, rock.transform.position.y, -2);
        this.transform.position = rockPos;
    }
}
