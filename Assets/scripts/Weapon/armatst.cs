using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armatst : MonoBehaviour {

    public GameObject bala;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Atirar() {
        Instantiate (bala, transform.position, transform.rotation);
    }
}
