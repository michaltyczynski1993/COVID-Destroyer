using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
//audio sources
public AudioSource buttonClick;

public void ButtonClickPlay()
{
    buttonClick.Play();
}
}
