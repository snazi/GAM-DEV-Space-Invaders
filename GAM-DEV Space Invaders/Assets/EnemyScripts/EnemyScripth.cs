using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScripth : MonoBehaviour {

    private Transform trans;
    private int border1;
    private bool down;
    private int downFrames;
    private bool direction;
    public GameObject bullet;
    // Use this for initialization
    void Start()
    {
        trans = transform;
        border1 = 70;
        down = false;
        downFrames = 10;
        direction = true;
    }

    // Update is called once per frame
    void Update()
    {



        if (!down)
        {
            if (direction)
            {
                if (Random.value > 0.999) //%50 percent chance
                {//code here
                    Instantiate(bullet, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), transform.rotation);
                }
                trans.Translate(0.1f * 0.5f, 0, 0);
                border1--;
                if (border1 == 0)
                {
                    down = true;
                }
            }
            else
            {

                if (Random.value > 0.999) //%50 percent chance
                {//code here
                    Instantiate(bullet, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), transform.rotation);
                }
                trans.Translate(-0.1f * 0.5f, 0, 0);
                border1--;
                if (border1 == 0)
                {
                    down = true;
                }
            }



        }
        else
        {
            trans.Translate(0, -0.1f * 0.5f, 0);
            downFrames--;
            if (downFrames == 0)
            {
                down = false;
                downFrames = 10;
                border1 = 70;
                if (direction)
                    direction = false;
                else
                    direction = true;
            }
        }



    }
}
