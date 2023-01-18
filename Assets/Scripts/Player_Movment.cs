using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Movment : MonoBehaviour
{
    public Transform transform;
    public float speed = 40f;
    public float rotationSpeed = 5f;
    public Score_Manager food_score;
    public Score_Manager total_Score;
    public GameObject gameOverPanel;
    public GameObject PausePanel;
    public Button LeftMoveButton;
    public Button RightMoveButton;

    void Start()
    {
        Button btnLeft = LeftMoveButton.GetComponent<Button>();
		btnLeft.onClick.AddListener(LeftMovement);
        Button btnRight = RightMoveButton.GetComponent<Button>();
		btnRight.onClick.AddListener(RightMovement);

        gameOverPanel.SetActive(false);
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        
    }

    void Update()
    {
        Clamp();
        if(food_score.foodScore<=0){
            Time.timeScale = 0 ;
            PausePanel.SetActive(true);
        }
         
    }
    public void RightMovement(){
		Debug.Log ("You have clicked the button!");
        transform.position += new Vector3(speed * Time.deltaTime ,0,0);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,17), rotationSpeed * Time.deltaTime);
	}
    public void LeftMovement(){
		Debug.Log ("You have clicked the button!");
        transform.position -= new Vector3(speed * Time.deltaTime ,0,0);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,57), rotationSpeed * Time.deltaTime);
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
