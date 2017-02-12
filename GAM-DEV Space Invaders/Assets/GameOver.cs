using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
	public Button button;
	public Transform trans;
	// Use this for initialization
	void Start () {
		trans = transform;
		//button = Button;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void gameOver(){
		//button = (Button) GameObject.FindGameObjectWithTag ("gobtn");
		//button.transform.Translate(new Vector3(0,59,0));
    }
}
