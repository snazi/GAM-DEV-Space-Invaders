using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundsScript : MonoBehaviour {
    private Transform trans;
    // Use this for initialization
    void Start () {
        trans = transform;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("collide");
        Destroy(col.gameObject);
    }

}
