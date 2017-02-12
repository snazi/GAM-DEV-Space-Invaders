using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theScript : MonoBehaviour {
    private int score;
    private TextMesh scoreText;

    private static theScript _instance;

    public static theScript Instance
    {
        get
        {
            if (_instance == null)
                _instance = (theScript)FindObjectOfType(typeof(theScript));
            return _instance;
        }
    }

	// Use this for initialization
	void Start () {
        scoreText = (TextMesh)GetComponent(typeof(TextMesh));
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void scorePoint()
    {   
        score++;
        scoreText.text = "Score: " + score;
    }

    public int getScore()
    {
        return score;
    }
}
