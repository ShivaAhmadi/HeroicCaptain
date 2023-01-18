using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Spawner : MonoBehaviour
{
    public GameObject[] food;

    void Start()
    {
        StartCoroutine(SpawnFoods());
    }

    void Update()
    {
        
    }

    void Foods()
    {
        int randfood = Random.Range(0,food.Length);
        float randXPos= Random.Range(-0.94f,0.78f);
        Instantiate(food[randfood], new Vector3(randXPos, transform.position.y,transform.position.z) ,Quaternion.Euler(0,0,0));
    }

    IEnumerator SpawnFoods() {
       while(true){
            int time = Random.Range(4,9);
            yield return new WaitForSeconds(time);
            Foods();
       }
       
    }
}
