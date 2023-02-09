using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour{


    private MeshRenderer bckgrdMR;
    private Vector2 movimiento = Vector2.zero;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start(){
        bckgrdMR = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update(){
        movimiento.x += speed * Time.deltaTime;
        bckgrdMR.material.mainTextureOffset = movimiento;
    }
}
