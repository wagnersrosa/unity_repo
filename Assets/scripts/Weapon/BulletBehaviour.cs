using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public float speed;
    public float timeToLive;
    private float currentTimeToLive;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        currentTimeToLive += Time.deltaTime;

       if (currentTimeToLive >= timeToLive)
        {
            Destroy(gameObject);

        }
	}
}
