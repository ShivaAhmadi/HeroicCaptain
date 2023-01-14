using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock_Spawner : MonoBehaviour
{
    public GameObject[] rock;

    void Start()
    {
        StartCoroutine(SpawnRocks());
    }

    void Update()
    {
        
    }

    void Rocks()
    {
            int rand = Random.Range(0,rock.Length);
            float randXPos= Random.Range(-0.94f,0.78f);
            Instantiate(rock[rand], new Vector3(randXPos, transform.position.y,transform.position.z) ,Quaternion.Euler(0,0,0));
        
    }

    IEnumerator SpawnRocks() {
       while(true){
             yield return new WaitForSeconds(2);
               Rocks();
       }
       
    }
}
