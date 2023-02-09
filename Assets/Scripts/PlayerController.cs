using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour{


	public float xMin, xMax, zMin, zMax;

    public float speed;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float nextFire;

    void Update(){
    	if(Input.GetButton("Fire1") && Time.time > nextFire){
    		nextFire = Time.time + fireRate;
    		Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            GetComponent<AudioSource>().Play();
    	}
    }
    // Update is called once per frame
    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().velocity = movement *speed;
        GetComponent<Rigidbody>().position = new Vector3

        (
        	Mathf.Clamp (GetComponent<Rigidbody>().position.x, xMin, xMax),
        	0.0f,
        	Mathf.Clamp (GetComponent<Rigidbody>().position.z, zMin, zMax)
        );
        
    }
}
