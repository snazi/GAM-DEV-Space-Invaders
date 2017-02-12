using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {
	public Transform trans;
	public GameObject bulletBody;
    private int test;

	// Use this for initialization
	void Start () {
		trans = transform;
		bulletBody = gameObject;
        test = 0;
	}
	
	// Update is called once per frame
	void Update () {
		trans.Translate(0, 0.3f, 0);
	}

	private void OnCollisionEnter(Collision col)
	{
        if (col.gameObject.tag == "boundary")
        {
            Debug.Log("boundary is hit");
        }else if(col.gameObject.tag == "enemy")
        {
            
            Destroy(col.gameObject);
            Destroy(bulletBody);
            
            //to make sure that we only increment the score once. On Collision fires multiple times and IDK why
            test++;
            Debug.Log(test);
            if (test < 2)
            theScript.Instance.scorePoint();

        }
        else
        {
            Destroy(col.gameObject);
        }
    }
}
