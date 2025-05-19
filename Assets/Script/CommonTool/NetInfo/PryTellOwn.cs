/***
 * 
 * 
 * 网络信息控制
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System.Runtime.InteropServices;
//using MoreMountains.NiceVibrations;

public class PryTellOwn : MonoBehaviour
{

    public static PryTellOwn instance;
    //请求超时时间
    private static float TIMEOUT= 3f;
[UnityEngine.Serialization.FormerlySerializedAs("BaseUrl")]    //base
    public string TineEat;
[UnityEngine.Serialization.FormerlySerializedAs("BaseLoginUrl")]    //登录url
    public string TineGlareEat;
[UnityEngine.Serialization.FormerlySerializedAs("BaseConfigUrl")]    //配置url
    public string TineBarterEat;
[UnityEngine.Serialization.FormerlySerializedAs("BaseTimeUrl")]    //时间戳url
    public string TineSureEat;
[UnityEngine.Serialization.FormerlySerializedAs("BaseAdjustUrl")]    //更新AdjustId url
    public string TineMaroonEat;
[UnityEngine.Serialization.FormerlySerializedAs("GameCode")]    //后台gamecode
    public string TownSpin= "20000";
[UnityEngine.Serialization.FormerlySerializedAs("Channel")]
    //channel渠道平台
#if UNITY_IOS
    public string Adverse= "AppStore";
#elif UNITY_ANDROID
    public string Channel = "GooglePlay";
#else
    public string Channel = "Other";
#endif
    //工程包名
    private string FlickerBull{ get { return Application.identifier; } }
    //登录url
    private string GlareEat= "";
    //配置url
    private string BarterEat= "";
    //更新AdjustId url
    private string MaroonEat= "";
[UnityEngine.Serialization.FormerlySerializedAs("country")]    //国家
    public string Kinglet= "";
[UnityEngine.Serialization.FormerlySerializedAs("ConfigData")]    //服务器Config数据
    public SneezeWise BarterWise;
[UnityEngine.Serialization.FormerlySerializedAs("InitData")]    //游戏内数据
    public Init RakeWise;
[UnityEngine.Serialization.FormerlySerializedAs("GameData")]    public Game TownWise;
[UnityEngine.Serialization.FormerlySerializedAs("adManager")]    //ADManager
    public GameObject OnWorship;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("gaid")]    public string Tear;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("aid")]    public string Ice;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("idfa")]    public string Work;
    int Towel_North= 0;
[UnityEngine.Serialization.FormerlySerializedAs("ready")]    public bool Towel= false;

    void Awake()
    {
        instance = this;
        GlareEat = TineGlareEat + TownSpin + "&channel=" + Adverse + "&version=" + Application.version;
        BarterEat = TineBarterEat + TownSpin + "&channel=" + Adverse + "&version=" + Application.version;
        MaroonEat = TineMaroonEat + TownSpin;
    }
    private void Start()
    {

        if (Application.platform == RuntimePlatform.Android)
        {
            AndroidJavaClass aj = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject p = aj.GetStatic<AndroidJavaObject>("currentActivity");
            p.Call("getGaid");
            p.Call("getAid");

        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
#if UNITY_IOS
            Glare();           //编辑器登录
#endif
        }
        else
        {
            Glare();           //编辑器登录
        }
        //获取config数据
        EraBarterWise();
    }

    /// <summary>
    /// 获取gaid回调
    /// </summary>
    /// <param name="gaid_str"></param>
    public void gaidAction(string gaid_str)
    {
        Debug.Log("unity收到gaid：" + gaid_str);
        Tear = gaid_str; 
        if (Tear == null || Tear == "")
        {
            Tear = FailWiseWorship.EraThrive("gaid");
        }
        else
        {
            FailWiseWorship.FatThrive("gaid", Tear);
        }
        Towel_North++;
        if (Towel_North == 2)
        {
            Glare();
        }
    }
    /// <summary>
    /// 获取aid回调
    /// </summary>
    /// <param name="aid_str"></param>
    public void aidAction(string aid_str)
    {
        Debug.Log("unity收到aid：" + aid_str);
        Ice = aid_str;
        if (Ice == null || Ice == "")
        {
            Ice = FailWiseWorship.EraThrive("aid");
        }
        else
        {
            FailWiseWorship.FatThrive("aid", Ice);
        }
        Towel_North++;
        if (Towel_North == 2)
        {
            Glare();
        }
    }
    /// <summary>
    /// 获取idfa成功
    /// </summary>
    /// <param name="message"></param>
    public void idfaSuccess(string message)
    {
        Debug.Log("idfa success:" + message);
        Work = message;
        FailWiseWorship.FatThrive("idfa", Work);
        Glare();
    }
    /// <summary>
    /// 获取idfa失败
    /// </summary>
    /// <param name="message"></param>
    public void idfaFail(string message)
    {
        Debug.Log("idfa fail");
        Work = FailWiseWorship.EraThrive("idfa");
        Glare();
    }
    /// <summary>
    /// 登录
    /// </summary>
    public void Glare()
    {
        //获取本地缓存的Local用户ID
        string localId = FailWiseWorship.EraThrive(CBarter.My_KrillJadeSo);

        //没有用户ID，视为新用户，生成用户ID
        if (localId == "" || localId.Length == 0)
        {
            //生成用户随机id
            TimeSpan st = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0);
            string timeStr = Convert.ToInt64(st.TotalSeconds).ToString() + UnityEngine.Random.Range(0, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString();
            localId = timeStr;
            FailWiseWorship.FatThrive(CBarter.My_KrillJadeSo, localId);
        }

        //拼接登录接口参数
        string url = "";
        if (Application.platform == RuntimePlatform.IPhonePlayer)       //一个参数 - iOS
        {
            url = GlareEat + "&" + "randomKey" + "=" + localId + "&idfa=" + Work + "&packageName=" + FlickerBull;
        }
        else if (Application.platform == RuntimePlatform.Android)  //两个参数 - Android
        {
            url = GlareEat + "&" + "randomKey" + "=" + localId + "&gaid=" + Tear + "&androidId=" + Ice + "&packageName=" + FlickerBull;
        }
        else //编辑器
        {
            url = GlareEat + "&" + "randomKey" + "=" + localId + "&packageName=" + FlickerBull;
        }

        //获取国家信息
        RubOutflow(() => {
            url += "&country=" + Kinglet;
            //登录请求
            PryYarnWorship.EraChlorine().ThanEra(url,
                (data) => {
                    Debug.Log("Login 成功" + data.downloadHandler.text);
                    FailWiseWorship.FatThrive("init_time", DateTime.Now.ToString());
                    ServerUserData serverUserData = JsonMapper.ToObject<ServerUserData>(data.downloadHandler.text);
                    FailWiseWorship.FatThrive(CBarter.My_KrillSneezeSo, serverUserData.data.ToString());

                    //RichMaroonDeco();
                },
                () => {
                    Debug.Log("Login 失败");
                });
        });
    }
    /// <summary>
    /// 获取国家
    /// </summary>
    /// <param name="cb"></param>
    private void RubOutflow(Action cb)
    {
        bool callBackReady = false;
        if (String.IsNullOrEmpty(Kinglet))
        {
            //获取国家超时返回
            StartCoroutine(PryYarnSureTwo(() =>
            {
                if (!callBackReady)
                {
                    Kinglet = "";
                    callBackReady = true;
                    cb?.Invoke();
                }
            }));
            PryYarnWorship.EraChlorine().ThanEra("https://a.mafiagameglobal.com/event/country/", (data) =>
            {
                Kinglet = JsonMapper.ToObject<Dictionary<string, string>>(data.downloadHandler.text)["country"];
                Debug.Log("获取国家 成功:" + Kinglet);
                if (!callBackReady)
                {
                    callBackReady = true;
                    cb?.Invoke();
                }
            },
            () => {
                Debug.Log("获取国家 失败");
                if (!callBackReady)
                {
                    Kinglet = "";
                    callBackReady = true;
                    cb?.Invoke();
                }
            });
        }
        else
        {
            if (!callBackReady)
            {
                callBackReady = true;
                cb?.Invoke();
            }
        }
    }

    /// <summary>
    /// 获取服务器Config数据
    /// </summary>
    private void EraBarterWise()
    {
        Debug.Log("GetConfigData:" + BarterEat);
        StartCoroutine(PryYarnSureTwo(() =>
        {
            EraAudienceWise();
        }));

        //获取并存入Config
        PryYarnWorship.EraChlorine().ThanEra(BarterEat,
        (data) => {
            Debug.Log("ConfigData 成功" + data.downloadHandler.text);
            FailWiseWorship.FatThrive("OnlineData", data.downloadHandler.text);
            FatBarterWise(data.downloadHandler.text);
        },
        () => {
            Debug.Log("ConfigData 失败");
        });
    }

    /// <summary>
    /// 获取本地Config数据
    /// </summary>
    private void EraAudienceWise()
    {
        //是否有缓存
        if (FailWiseWorship.EraThrive("OnlineData") == "" || FailWiseWorship.EraThrive("OnlineData").Length == 0)
        {
            Debug.Log("本地数据");
            TextAsset Hand= Resources.Load<TextAsset>("LocationJson/LocationData");
            FatBarterWise(Hand.text);
        }
        else
        {
            Debug.Log("服务器缓存数据");
            FatBarterWise(FailWiseWorship.EraThrive("OnlineData"));
        }
    }


    /// <summary>
    /// 解析config数据
    /// </summary>
    /// <param name="configJson"></param>
    void FatBarterWise(string configJson)
    {
        //如果已经获得了数据则不再处理
        if (BarterWise == null)
        {
            RootData rootData = JsonMapper.ToObject<RootData>(configJson);
            BarterWise = rootData.data;
            RakeWise = JsonMapper.ToObject<Init>(BarterWise.init);
            TownWise = JsonMapper.ToObject<Game>(BarterWise.game);
            TownSpeak();
        }
    }
    /// <summary>
    /// 进入游戏
    /// </summary>
    void TownSpeak()
    {
        //打开admanager
        OnWorship.SetActive(true);
        //进度条可以继续
        Towel = true;
    }



    /// <summary>
    /// 超时处理
    /// </summary>
    /// <param name="finish"></param>
    /// <returns></returns>
    IEnumerator PryYarnSureTwo(Action finish)
    {
        yield return new WaitForSeconds(TIMEOUT);
        finish();
    }

    /// <summary>
    /// 向后台发送adjustId
    /// </summary>
    public void RichMaroonDeco()
    {
       
    }
}
