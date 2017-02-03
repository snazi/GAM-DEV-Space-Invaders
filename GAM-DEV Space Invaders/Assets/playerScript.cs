using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {
    private Transform trans;
	// Use this for initialization
	void Start () {
        trans = transform;
	}
	
	// Update is called once per frame
	void Update () {
        float offsetX = Input.GetAxis("Horizontal");
        if (offsetX > 0)
            trans.Translate(offsetX*0.5f, 0, 0);
        else if (offsetX < 0)
            trans.Translate(offsetX*0.5f, 0, 0);

	}
}
