using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject virus;
    public Text scoreText;
    private float randomX;
    private float randomY;
    private float randomZ;
    public bool isGameOver;
    public int score;
    public int virusKillCount;
    public float spawnRate;

    void Awake() 
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }    
    }

    void Start()
    {
        spawnRate = 5.0f;
        //InvokeRepeating("Spawn", spawnTime, spawnRate);
        isGameOver = false;
        score = 0;
        virusKillCount = 0;
        StartCoroutine("SpawnVirus");
    }
    
    private IEnumerator SpawnVirus()
    {
        while (true)
        {
             Spawn();
             yield return new WaitForSeconds(spawnRate);
        }
    }

    void Spawn()
    {
        //spawn virus in random position
        randomX = Random.Range(-20.0f, 20.0f);
        randomY = Random.Range(1.0f, 10.0f);
        randomZ = Random.Range(-5.0f, 9.0f);
        Instantiate(virus, new Vector3(randomX, randomY, randomZ), Quaternion.identity);
    }
   
   public void GameOver()
   {
       //all things after game is over
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Virus");
        foreach(GameObject enemy in enemies)
        GameObject.Destroy(enemy);
        isGameOver = true;
        StopCoroutine("SpawnVirus");
        Debug.Log("Game Over!");
        //show main menu - not wrote yet
   }

   public void IncreaseSpawnRate()
   {
       if (spawnRate > 1)
       {
           spawnRate--;
       }
   }
}
