using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusDestroy : MonoBehaviour
{
    public void DestroyCube()
    {
        Destroy(gameObject);
        
        GameController.instance.virusKillCount++;
        if (GameController.instance.virusKillCount == 5)
        {
            //random score bonus after kill 5 viruses
            int rnd = Random.Range(2,4);
            GameController.instance.score = GameController.instance.score +rnd;
            GameController.instance.virusKillCount = 0;
            //also play sound when narrator said "Bonus!"
            GameController.instance.IncreaseSpawnRate();
        }
        else
        {
            GameController.instance.score++;
        }
        GameController.instance.scoreText.text = "Score: "+ GameController.instance.score * 100;
    }
}
