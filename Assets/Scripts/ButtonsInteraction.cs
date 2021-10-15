using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsInteraction : MonoBehaviour
{
    public AudioSource audiomanager;
   
   public void Enter()
   {
        audiomanager.Play();
        StartCoroutine("LoadLevel");
   }

   IEnumerator LoadLevel()
   {
       yield return new WaitForSeconds(1);
       SceneManager.LoadScene(1);
   }
}
