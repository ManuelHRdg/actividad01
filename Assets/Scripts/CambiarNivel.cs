using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarNivel : MonoBehaviour {

    public bool pasarNivel;
    public int indiceNivel;
    
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            CambioNivel(indiceNivel);
        }

        if(pasarNivel){
            CambioNivel(indiceNivel);
        }
    }

    public void CambioNivel(int indice){
        SceneManager.LoadScene(indice);
    }

    public void Salir(){
        Debug.Log("Regresa Pronto"); 
        Application.Quit();
    }
}
