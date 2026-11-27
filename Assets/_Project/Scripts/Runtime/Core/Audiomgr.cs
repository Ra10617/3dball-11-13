using System;
using UnityEngine;
 
public class AudioMgr : MonoBehaviour
{
    public AudioSource audioSource;
 
    private void Awake()
    {
        //如果GameDB的Audio 不存在
        if (GameDB.Audio == null)
        {
            GameDB.Audio = this;   //連動自己
            audioSource = GetComponent<AudioSource>();  //自己抓AudioSource元件來用
            DontDestroyOnLoad(this.gameObject); //禁止銷毀
        }
        else  //否則表示 AudioMgr 已經存在
        {
            Destroy(gameObject);
        }
    }
 
    void Start()
    {
         
    }
 
    void Update()
    {
         
    }
 
    public void Play(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
     
    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
     
}
