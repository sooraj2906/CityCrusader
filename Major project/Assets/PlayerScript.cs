using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
	public int points ;
	public Text score;
    public GameObject FrontCam;
    public GameObject BackCam;

	// Use this for initialization
	void Start () {
        BackCam.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () 
	{
        score.text = "Score : " + points.ToString();

        if(Input.GetKeyDown(KeyCode.V))
        {
            FrontCam.SetActive(false);
            BackCam.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.V))
        {
            FrontCam.SetActive(true);
            BackCam.SetActive(false);
        }
    }

     void OnCollisionEnter(Collision others)
    {
        if(others.gameObject.tag =="AI")
        {   
            SceneManager.LoadScene(2);
        }
    }

}
