using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinContainer : MonoBehaviour {
    public float coinCount;
   
    void Start () {

        coinCount = this.transform.childCount;
		
	}
	
	
	void Update () {


        if (coinCount <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
