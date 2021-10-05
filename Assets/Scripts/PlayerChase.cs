using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChase : MonoBehaviour
{
    private Transform player;
    private int maxSpeed = 4;
    
    void Start() 
    {
        player = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        transform.LookAt(player);
        transform.position += transform.forward * maxSpeed * Time.deltaTime;
    }
}
