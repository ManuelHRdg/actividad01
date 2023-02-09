using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour{
    public GameObject hazard;
    public Vector3 spawnValues; //Ubicación de "nacimiento" de antagonistas (47,0,17)
    public int hazardCount;     //Número de enemigos por oleada (5)
    public float spawnWait;     //Tiempo de espera entre antagonista y antagonista en la misma oleada (.5)
    public float startWait;     //Tiempo de espera antes de iniciar las oleadas (5)
    public float waveWait;      //Tempo de espera entre oleadas (3)

    void Start (){
        StartCoroutine (SpawnWaves());
    }

    IEnumerator SpawnWaves (){
        yield return new WaitForSeconds (startWait);
        while (true){
            for (int i = 0; i < hazardCount; i++){
                Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, Random.Range (-spawnValues.z, spawnValues.z));
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate (hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds (spawnWait);
            }
            yield return new WaitForSeconds (waveWait);
        }
    }
}
