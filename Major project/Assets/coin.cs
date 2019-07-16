using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coin : MonoBehaviour 
{
    public CoinContainer contain;
	// Use this for initialization
	void Start ()
	{
        contain = FindObjectOfType<CoinContainer>();
	}
	
	// Update is called once per frame
	void Update () 
	{   
		
	}

	public void OnTriggerEnter(Collider other)
	{
		Debug.Log(other.name);
		if(other.gameObject.tag == "Player")
		{

			other.GetComponentInParent<PlayerScript>().points+=1;
			Destroy(this.gameObject);
            contain.coinCount--;
		}
	}
}
