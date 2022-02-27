using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowKeys : MonoBehaviour
{
    public float playerSpeed;
    public GameObject playerBody;
    public GameObject enemyBody;
    public float health;
    public float hitdamage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey("w")) {
           playerBody.transform.position += new Vector3(playerSpeed * Time.deltaTime, 0, 0);
       }
       if (Input.GetKey("s")) {
           playerBody.transform.position -= new Vector3(playerSpeed * Time.deltaTime, 0, 0);
       }
       if (Input.GetKey("a")) {
           playerBody.transform.position += new Vector3(0, 0, playerSpeed * Time.deltaTime);
       }
       if (Input.GetKey("d")) {
           playerBody.transform.position -= new Vector3(0, 0, playerSpeed * Time.deltaTime);
       }
      
    }
    void OnTriggerEnter(Collider other){
        if (1 == 1){ //(other.gameObject.tag == "enemy"){
            health -= hitdamage;
            Debug.Log("Got hit");
        }
    }
}
