/***
 * 
 * 音乐管理器
 * 
 * **/
using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgreeOwn : CoatOutnumber<AgreeOwn>
{
    //音频组件管理队列的对象
    private CoachAthensValse CoachValse;
    // 用于播放背景音乐的音乐源
    private AudioSource m_ToAgree=null;
    //播放音效的音频组件管理列表
    private List<AudioSource> LuceCoachAthensPity;
    //检查已经播放的音频组件列表中没有播放的组件的更新频率
    private float GypsyAssemble= 2f; 
    //背景音乐开关
    private bool _AtAgreeFusion;
    //音效开关
    private bool _EscapeAgreeFusion;
    //音乐音量
    private float _AtAdhere=1f;
    //音效音量
    private float _EscapeAdhere=1f;
    string BGM_Bull= "";

    public Dictionary<string, CoachBrass> CoachLifewayBird;

    // 控制背景音乐音量大小
    public float AtAdhere    {
        get { 
            return AtAgreeFusion ? RubAdhere(BGM_Bull) : 0f; 
        }
        set {
            _AtAdhere = value;
            //背景音乐开的状态下，声音随控制调节
        }
    }

    //控制音效音量的大小
    public float EscapeInjury    {
        get { return _EscapeAdhere; }
        set { 
            _EscapeAdhere = value;
            FatJetEscapeAdhere();
        }
    }
    //控制背景音乐开关
    public bool AtAgreeFusion    {
        get {

            _AtAgreeFusion = FailWiseWorship.EraKnow("_BgMusicSwitch");
            return _AtAgreeFusion; 
        }
        set {
            if(m_ToAgree)
            {
                _AtAgreeFusion = value;
                FailWiseWorship.FatKnow("_BgMusicSwitch", _AtAgreeFusion);
                m_ToAgree.volume = AtAdhere; 
            }
        }
    }
    public void AskBgmWheelOftSure()
    {
        m_ToAgree.volume = 0;
    }
    public void AskRidSignifyOftSure()
    {
        m_ToAgree.volume = AtAdhere;
    }
    //控制音效开关
    public bool EscapeAgreeFusion    {
        get {
            _EscapeAgreeFusion = FailWiseWorship.EraKnow("_EffectMusicSwitch");
            return _EscapeAgreeFusion; 
        }
        set {
            _EscapeAgreeFusion = value;
            FailWiseWorship.FatKnow("_EffectMusicSwitch", _EscapeAgreeFusion);
            
        }
    }
    public AgreeOwn()
    {
        LuceCoachAthensPity = new List<AudioSource>();      
    }
    protected override void Awake()
    {
        if (!PlayerPrefs.HasKey("first_music_setBool") || !FailWiseWorship.EraKnow("first_music_set"))
        {
            FailWiseWorship.FatKnow("first_music_set", true);
            FailWiseWorship.FatKnow("_BgMusicSwitch", true);
            FailWiseWorship.FatKnow("_EffectMusicSwitch", true);
        }
        CoachValse = new CoachAthensValse(this);

        TextAsset Hand= Resources.Load<TextAsset>("Audio/AudioInfo");
        CoachLifewayBird = JsonMapper.ToObject<Dictionary<string, CoachBrass>>(Hand.text);
    }
    private void Start()
    {
        StartCoroutine("GypsyToZooCoachTemporary");
    }
    /// <summary>
    /// 定时检查没有使用的音频组件并回收
    /// </summary>
    /// <returns></returns>
    IEnumerator GypsyToZooCoachTemporary()
    {
        while (true)
        {
            //定时更新
            yield return new WaitForSeconds(GypsyAssemble);
            for (int i = 0; i < LuceCoachAthensPity.Count; i++)
            {
                //防止数据越界
                if (i < LuceCoachAthensPity.Count)
                {
                    //确保物体存在
                    if (LuceCoachAthensPity[i])
                    {
                        //音频为空或者没有播放为返回队列条件
                        if ((LuceCoachAthensPity[i].clip == null || !LuceCoachAthensPity[i].isPlaying))
                        {
                            //返回队列
                            CoachValse.ToZooCoachTemporary(LuceCoachAthensPity[i]);
                            //从播放列表中删除
                            LuceCoachAthensPity.Remove(LuceCoachAthensPity[i]);
                        }
                    }
                    else
                    {
                        //移除在队列中被销毁但是是在list中存在的垃圾数据
                        LuceCoachAthensPity.Remove(LuceCoachAthensPity[i]);
                    }                 
                }            
               
            }
        }
    }
    /// <summary>
    /// 设置当前播放的所有音效的音量
    /// </summary>
    private void FatJetEscapeAdhere()
    {
        for (int i = 0; i < LuceCoachAthensPity.Count; i++)
        {
            if (LuceCoachAthensPity[i] && LuceCoachAthensPity[i].isPlaying)
            {
                LuceCoachAthensPity[i].volume = _EscapeAgreeFusion ? _EscapeAdhere : 0f;
            }
        }
    }
    /// <summary>
    /// 播放背景音乐，传进一个音频剪辑的name
    /// </summary>
    /// <param name="bgName"></param>
    /// <param name="restart"></param>
    private void LuceAtTine(object bgName, bool restart = false)
    {

        BGM_Bull = bgName.ToString();
        if (m_ToAgree == null)
        {
            //拿到一个音频组件  背景音乐组件在某一时间段唯一存在
            m_ToAgree = CoachValse.EraCoachTemporary();
            //开启循环
            m_ToAgree.loop = true;
            //开始播放
            m_ToAgree.playOnAwake = false;
            //加入播放列表
            //PlayAudioSourceList.Add(m_bgMusic);
        }

        if (!AtAgreeFusion)
        {
            m_ToAgree.volume = 0;
        }

        //定义一个空的字符串
        string curBgName = string.Empty;
        //如果这个音乐源的音频剪辑不为空的话
        if (m_ToAgree.clip != null)
        {
            //得到这个音频剪辑的name
            curBgName = m_ToAgree.clip.name;
        }

        // 根据用户的音频片段名称, 找到AuioClip, 然后播放,
        //ResourcesMgr是提前定义好的查找音频剪辑对应路径的单例脚本，并动态加载出来
        AudioClip clip = Resources.Load<AudioClip>(CoachLifewayBird[BGM_Bull].filePath);
        //如果找到了，不为空
        if (clip != null)
        {
            //如果这个音频剪辑已经复制给类音频源，切正在播放，那么直接跳出
            if (clip.name == curBgName && !restart)
            {
                return;
            }
            //否则，把改音频剪辑赋值给音频源，然后播放
            m_ToAgree.clip = clip;
            m_ToAgree.volume = AtAdhere;
            m_ToAgree.Play();
        }
        else
        {
            //没找到直接报错
            // 异常, 调用写日志的工具类.
            //UnityEngine.Debug.Log("没有找到音频片段");
            if (m_ToAgree.isPlaying)
            {
                m_ToAgree.Stop();
            }
            m_ToAgree.clip = null;
        }
    }
    /// <summary>
    /// 播放音效
    /// </summary>
    /// <param name="effectName"></param>
    /// <param name="defAudio"></param>
    /// <param name="volume"></param>
    private void LuceEscapeTine(object effectName, bool defAudio = true, float volume = 1f)
    {
        if (!EscapeAgreeFusion)
        {
            return;
        }
        //获取音频组件
        AudioSource m_effectMusic = CoachValse.EraCoachTemporary();
        if (m_effectMusic.isPlaying) {
            //Debug.Log("-------------------------------当前音效正在播放,直接返回");
            return;
        };
        m_effectMusic.loop = false;
        m_effectMusic.playOnAwake = false;
        m_effectMusic.volume = RubAdhere(effectName.ToString());
        //Debug.Log(m_effectMusic.volume);
        //根据查找路径加载对应的音频剪辑
        AudioClip clip = Resources.Load<AudioClip>(CoachLifewayBird[effectName.ToString()].filePath);
        //如果为空的话，直接报错，然后跳出
        if (clip == null)
        {
            //UnityEngine.Debug.Log("没有找到音效片段");
            //没加入播放列表直接返回给队列
            CoachValse.ToZooCoachTemporary(m_effectMusic);
            return;
        }
        m_effectMusic.clip = clip;
        //加入播放列表
        LuceCoachAthensPity.Add(m_effectMusic);
        //否则，就是clip不为空的话，如果defAudio=true，直接播放
        if (defAudio)
        {
            m_effectMusic.PlayOneShot(clip, volume);
        }
        else
        {
            //指定点播放
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
        }
    }

    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void LuceAt(AgreeFirm.UIMusic bgName, bool restart = false)
    {
        LuceAtTine(bgName, restart);
    }

    public void LuceAt(AgreeFirm.SceneMusic bgName, bool restart = false)
    {
        LuceAtTine(bgName, restart);
    }

    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void LuceEscape(AgreeFirm.UIMusic effectName, bool defAudio = true, float volume = 1f)
    {
        LuceEscapeTine(effectName, defAudio, volume);
    }

    public void LuceEscape(AgreeFirm.SceneMusic effectName, bool defAudio = true, float volume = 1f)
    {
        LuceEscapeTine(effectName, defAudio, volume);
    }
    float RubAdhere(string name)
    {
        if (CoachLifewayBird == null)
        {
            TextAsset Hand= Resources.Load<TextAsset>("Audio/AudioInfo");
            CoachLifewayBird = JsonMapper.ToObject<Dictionary<string, CoachBrass>>(Hand.text);
        }

        if (CoachLifewayBird.ContainsKey(name))
        {
             return (float)CoachLifewayBird[name].volume;

        }
        else
        {
            return 1;
        }
    }

}