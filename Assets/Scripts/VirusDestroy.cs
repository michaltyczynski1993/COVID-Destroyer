using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusDestroy : MonoBehaviour
{   //Particle System instantion
    public GameObject explosion;
    public AudioClip dieSound;
    private float soundVolume = 0.9f;
    
    public void DestroyCube()
    {
        //Play Particle System explosion on virus destroy
        AudioSource.PlayClipAtPoint(dieSound, this.transform.position, soundVolume);
        Instantiate(explosion, this.transform.position, this.transform.rotation);
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
