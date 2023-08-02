using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    //antes de golpear al obstaculo
    public float startDelay = 2.0f;
    //mientras esta golpeando los obstaculos
    public float repeatRate = 2.0f;

    //referencia a objeto tipo player controler - los scripts son clases
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        //comunicacion entre scripts
        //player=nombre del objeto - poner nombres intuitivos
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        //            tardanza al principio, cuanto se tarda
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}