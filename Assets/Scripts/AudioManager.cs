using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    
    void Start()
    {
        foreach(Sound s in sounds)
        {
            s.audioSource=gameObject.AddComponent<AudioSource>();
            s.audioSource.clip = s.clip;
            s.audioSource.loop = s.loop;
        }
        PlaySound("MainTheme");
    }
    public void PlaySound(string name)
    {
        foreach (Sound s in sounds)
        {
            if(s.name==name)
            {
                s.audioSource.Play();   
            }

        }
    }

}
