using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour{
    public float lifetime = 3f;

    void Start (){
        Destroy (gameObject, lifetime);
    }
}