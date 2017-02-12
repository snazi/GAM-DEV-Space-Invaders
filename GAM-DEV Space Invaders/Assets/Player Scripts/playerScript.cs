using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {
    private Transform trans;
	public GameObject bullet;

    private GameObject[] getCount;

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

        
        getCount = GameObject.FindGameObjectsWithTag("bullet");
        int count = getCount.Length;

        if (Input.GetKeyDown("space") && count < 3)
		{
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y+1, transform.localPosition.z), transform.rotation);
        }
	
	}

	void OnCollisionEnter(Collision col){
            Destroy(col.gameObject);
        //Reset Game
    }
}
