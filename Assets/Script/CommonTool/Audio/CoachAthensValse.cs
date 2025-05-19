/***
 * 
 * AudioSource组件管理(音效，背景音乐除外)
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CoachAthensValse 
{
    //音乐的管理者
    private GameObject CoachOwn;
    //音乐组件管理队列
    private List<AudioSource> CoachTemporaryValse;
    //音乐组件默认容器最大值  
    private int RimCajun= 25;
    public CoachAthensValse(AgreeOwn audioMgr)
    {
        CoachOwn = audioMgr.gameObject;
        RakeCoachAthensValse();
    }
  
    /// <summary>
    /// 初始化队列
    /// </summary>
    private void RakeCoachAthensValse()
    {
        CoachTemporaryValse = new List<AudioSource>();
        for(int i = 0; i < RimCajun; i++)
        {
            BoxCoachAthensCowTinyOwn();
        }
    }
    /// <summary>
    /// 给音乐的管理者添加音频组件，同时组件加入队列
    /// </summary>
    private AudioSource BoxCoachAthensCowTinyOwn()
    {
        AudioSource audio = CoachOwn.AddComponent<AudioSource>();
        CoachTemporaryValse.Add(audio);
        return audio;
    }
    /// <summary>
    /// 获取一个音频组件
    /// </summary>
    /// <param name="audioMgr"></param>
    /// <returns></returns>
    public AudioSource EraCoachTemporary()
    {
        if (CoachTemporaryValse.Count > 0)
        {
            AudioSource audio = CoachTemporaryValse.Find(t => !t.isPlaying);
            if (audio)
            {
                CoachTemporaryValse.Remove(audio);
                return audio;
            }
            //队列中没有了，需额外添加
            return BoxCoachAthensCowTinyOwn();
            //直接返回队列中存在的组件
            //return AudioComponentQueue.Dequeue();
        }
        else
        {
            //队列中没有了，需额外添加
            return  BoxCoachAthensCowTinyOwn();
        }
    }
    /// <summary>
    /// 没有被使用的音频组件返回给队列
    /// </summary>
    /// <param name="audio"></param>
    public void ToZooCoachTemporary(AudioSource audio)
    {
        if (CoachTemporaryValse.Contains(audio)) return;
        if (CoachTemporaryValse.Count >= RimCajun)
        {
            GameObject.Destroy(audio);
            //Debug.Log("删除组件");
        }
        else
        {
            audio.clip = null;
            CoachTemporaryValse.Add(audio);
        }

        //Debug.Log("队列长度是" + AudioComponentQueue.Count);
    }
    
}
