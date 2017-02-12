using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyBullet : MonoBehaviour {
    public Transform trans;
    public GameObject bulletBody;
    public GameObject[] button;
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
            gameOver();
        }

    }

    public void gameOver()
    {
        button = GameObject.FindGameObjectsWithTag("gobtn");
		for(int i = 0; i< button.Length;i++)
			button[i].transform.Translate(new Vector3(0, 300 , 0));
    }
}
