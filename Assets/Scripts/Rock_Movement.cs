using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock_Movement : MonoBehaviour
{
    public Transform transformRock;
    public float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        transformRock = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transformRock.position -= new Vector3(0,speed * Time.deltaTime,0);
        if (transform.position.y <= -10) {
            Destroy(gameObject);
        }
    }
}
