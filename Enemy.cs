using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed;
    public GameObject enemyBody;
    public GameObject playerBody;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = (enemyBody.transform.position - playerBody.transform.position);
        direction = direction / direction.magnitude;
        enemyBody.transform.position -= direction * enemySpeed * Time.deltaTime;
    }
}
