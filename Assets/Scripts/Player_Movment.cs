using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{
    public Transform transform;
    public float speed = 1.5f;
    public float rotationSpeed = 5f;
    public Score_Manager food_score;
    public Score_Manager total_Score;
    public GameObject gameOverPanel;
    public GameObject PausePanel;

    void Start()
    {
        gameOverPanel.SetActive(false);
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        
    }

    void Update()
    {
         Movment();
         Clamp();
        if(food_score.foodScore<=0){
            Time.timeScale = 0 ;
            PausePanel.SetActive(true);
        }
         
    }
     void Movment() {
 if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(speed * Time.deltaTime ,0,0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,17), rotationSpeed * Time.deltaTime);
        }

         if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position -= new Vector3(speed * Time.deltaTime ,0,0);
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,100), rotationSpeed * Time.deltaTime);
        }

        if (transform.rotation.z != 90) {
             transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,37), rotationSpeed * Time.deltaTime);
        }
    }

    void Clamp() {

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-1.56f,1.25f);
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Rock"){
               Time.timeScale = 0 ;
               gameOverPanel.SetActive(true);
        }
        if (collision.gameObject.tag == "Food"){
               food_score.foodScore += 10;
               Destroy(collision.gameObject);
        }
    }
}
