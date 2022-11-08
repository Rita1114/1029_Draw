using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMgr : MonoBehaviour
{
    public AudioMixer audioMixer;
    //public AudioMixer SoundEffectMixer;
    public AudioClip WalkSource;
    public AudioSource audioSource;

    #region ��

    void Start()
    {
     
    }
    

    void Update()
    {

    }
    #endregion
   

    public void SetMainVolume(float volume)
    {
        audioMixer.SetFloat("MasterVolume", volume);
    }
    public void SetBgmVolume(float volume)
    {
        audioMixer.SetFloat("BgmVolume", volume);
    }
    public void SetSoundEffectVolume(float volume)
    {
        audioMixer.SetFloat("Sound EffectVolume", volume);
    }
    public void WalkSourcePlay()
     {
       audioSource.clip = WalkSource;
       audioSource.Play();
       Debug.Log("123");
     }
}
