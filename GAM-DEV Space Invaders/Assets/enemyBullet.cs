using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour {
    public Transform trans;
    public GameObject bulletBody;
    // Use this for initialization
    void Start () {
        trans = transform;
        bulletBody = gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        trans.Translate(0, -0.3f, 0);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
        }

    }
}
