using System;
using UnityEngine;
 
public class AudioMgr : MonoBehaviour
{
    public AudioSource AudioSource;
 
    private void Awake()
    {
        //如果GameDB的Audio 不存在
        if (GameDB.Audio == null)
        {
            GameDB.Audio = this;   //連動自己
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
}
