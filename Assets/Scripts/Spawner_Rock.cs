using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Rock : MonoBehaviour
{
    public GameObject[] rock;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRocks());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Rocks()
    {
            int rand = Random.Range(0,rock.Length);
            float randXPos= Random.Range(-0.94f,0.78f);
            Instantiate(rock[rand], new Vector3(randXPos, transform.position.y,transform.position.z) ,Quaternion.Euler(0,0,90));
        
    }

    IEnumerator SpawnRocks() {
       while(true){
             yield return new WaitForSeconds(4);
               Rocks();
       }
       
    }
}
