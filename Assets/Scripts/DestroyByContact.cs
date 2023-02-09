using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DestroyByContact : MonoBehaviour{
    public GameObject explosion;

    void OnTriggerEnter(Collider other){
        if (other.tag == "Boundary"){
            return;
        }

        if (other.tag == "Enemy"){
            return;
        }
        
        Instantiate(explosion, transform.position, transform.rotation);
        
        if (other.tag == "Player"){
            Instantiate(explosion, other.transform.position, other.transform.rotation);
            SceneManager.LoadScene(0);
        }
        
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}