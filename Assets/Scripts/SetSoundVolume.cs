using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSoundVolume : MonoBehaviour
{

    void Start()
    {
        transform.GetComponent<AudioSource>().volume = GameSound.Instance.musicVolume;        
    }

    
}
