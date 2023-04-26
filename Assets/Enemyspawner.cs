using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
private Vector3 SpawnPos;
    public GameObject spawnObject;
    private float newSpawnDuration = 1f;

    #region Singleton

   private Enemyspawner Instance;

    private void Awake()
    {
        Instance = this;
    }

    #endregion

    private void Start()
    {
        SpawnPos = transform.position;
    }
    
    void SpawnNewObject()
    {
        Instantiate(spawnObject, SpawnPos, Quaternion.identity);
    }
    
    public void NewSpawnRequest()
    {
        Invoke("SpawnNewObject", newSpawnDuration);
    }    
}




    //[SerializedField]
    //private GameObject Target;
   // private GameObject Target = enemy;

    //private float TargetInterval = 3.5f;
    // Start is called before the first frame update
    //void Start()
   // {
       // StartCoroutine(SpawnEnemy(Target));
   // }

 // private IEnumerator SpawnEnemy(float interval, GameObject enemy)
  //{
   // yield return new WaitForSeconds(interval);
   // GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5),Random.Range(-6f, 6f), 0), Quaternion.identity);
    //StartCoroutine(SpawnEnemy(interval, enemy));
  //}
//}
