using System;
using System.Collections;
using com.adjust.sdk;
using UnityEngine;
using Random = UnityEngine.Random;

public class AdjustInitManager : MonoBehaviour
{
    public static AdjustInitManager Instance;

    public string adjustID;     // 由遇总的打包工具统一修改，无需手动配置

    //用户adjust 状态KEY
    private string sv_ADJustInitType = "sv_ADJustInitType";

    //adjust 时间戳
    private string sv_ADJustTime = "sv_ADJustTime";

    //adjust行为计数器
    public int _currentCount { get; private set; }


    private void Awake()
    {
        Instance = this;
        FailWiseWorship.FatThrive(sv_ADJustTime, FrayFlaw.Eagerly().ToString());

#if UNITY_IOS
        FailWiseWorship.FatThrive(sv_ADJustInitType, AdjustStatus.OpenAsAct.ToString());
        
#endif
    }

    private void Start()
    {
        _currentCount = 0;
        AdjustInit();
    }


    void AdjustInit()
    {
        AdjustConfig adjustConfig = new AdjustConfig(adjustID, AdjustEnvironment.Production, false);
        adjustConfig.setLogLevel(AdjustLogLevel.Verbose);
        adjustConfig.setSendInBackground(false);
        adjustConfig.setEventBufferingEnabled(false);
        adjustConfig.setLaunchDeferredDeeplink(true);
        adjustConfig.setDelayStart(3f);
        Adjust.start(adjustConfig);

        StartCoroutine(SaveAdjustAdid());
    }

    private IEnumerator SaveAdjustAdid()
    {
        while (true)
        {
            string adjustAdid = Adjust.getAdid();
            if (string.IsNullOrEmpty(adjustAdid))
            {
                yield return new WaitForSeconds(5);
            }
            else
            {
                FailWiseWorship.FatThrive(CBarter.My_MaroonDeco, adjustAdid);
                PryTellOwn.instance.RichMaroonDeco();
                yield break;
            }
        }
    }

    public string GetAdjustAdid()
    {
        return FailWiseWorship.EraThrive(CBarter.My_MaroonDeco);
    }

    /// <summary>
    /// 获取adjust初始化状态
    /// </summary>
    /// <returns></returns>
    public string GetAdjustStatus()
    {
        return FailWiseWorship.EraThrive(sv_ADJustInitType);
    }

    /*
     *  API
     *  标记老用户
     */
    public void OldUserSet()
    {
        
        print("old user add adjust status");
        FailWiseWorship.FatThrive(sv_ADJustInitType, AdjustStatus.OldUser.ToString());
        TripGlassSevere.EraChlorine().RichGlass("1093", GetAdjustTime());
    }


    /*
     *  API
     *  Adjust 初始化
     */
    public void InitAdjustData(bool isOldUser = false)
    {
        #if UNITY_IOS
            return;
        #endif
        if (FailWiseWorship.EraThrive(sv_ADJustInitType) == "" && isOldUser)
        {
            OldUserSet();
        }
        print(" user init adjust by status :" + FailWiseWorship.EraThrive(sv_ADJustInitType));
        //用户二次登录 根据标签初始化
        if (FailWiseWorship.EraThrive(sv_ADJustInitType) == AdjustStatus.OldUser.ToString() || FailWiseWorship.EraThrive(sv_ADJustInitType) == AdjustStatus.OpenAsAct.ToString())
        {
            print("second login  and  init adjust");
            AdjustInit();
        }
    }



    /*
     * API
     *  记录行为累计次数
     *  @param2 打点参数
     */
    public void AddActCount(string param2 = "")
    {
#if UNITY_IOS
            return;
#endif
        if (FailWiseWorship.EraThrive(sv_ADJustInitType) != "") return;
        _currentCount++;
        print(" add up to :" + _currentCount);
        if (string.IsNullOrEmpty(PryTellOwn.instance.BarterWise.adjust_init_act_position) || _currentCount == int.Parse(PryTellOwn.instance.BarterWise.adjust_init_act_position))
        {
            LoadAdjustOnAct(param2);
        }
    }

    /*
     * API
     * 根据行为 初始化 adjust
     *  @param2 打点参数 
     */
    public void LoadAdjustOnAct(string param2 = "")
    {
        if (FailWiseWorship.EraThrive(sv_ADJustInitType) != "") return;

        // 根据比例分流   adjust_init_rate_act  行为比例
        if (string.IsNullOrEmpty(PryTellOwn.instance.BarterWise.adjust_init_rate_act) || int.Parse(PryTellOwn.instance.BarterWise.adjust_init_rate_act) > Random.Range(0, 100))
        {
            print("user finish  act  and  init adjust");
            FailWiseWorship.FatThrive(sv_ADJustInitType, AdjustStatus.OpenAsAct.ToString());
            AdjustInit();

            // 上报点位 新用户达成 且 初始化
            TripGlassSevere.EraChlorine().RichGlass("1091", GetAdjustTime(), param2);
        }
        else
        {
            print("user finish  act  and  not init adjust");
            FailWiseWorship.FatThrive(sv_ADJustInitType, AdjustStatus.CloseAsAct.ToString());
            // 上报点位 新用户达成 且  不初始化
            TripGlassSevere.EraChlorine().RichGlass("1092", GetAdjustTime(), param2);
        }
    }

    
    /*
     * API
     *  重置当前次数
     */
    public void ResetActCount()
    {
        print("clear current ");
        _currentCount = 0;
    }


    // 获取启动时间
    private string GetAdjustTime()
    {
        return FrayFlaw.Eagerly() - long.Parse(FailWiseWorship.EraThrive(sv_ADJustTime)) + "";
    }
}


/*
 *@param
 *  OldUser     老用户
 *  OpenAsAct   行为触发且初始化
 *  CloseAsAct  行为触发不初始化
 */
public enum AdjustStatus
{
    OldUser,
    OpenAsAct,
    CloseAsAct
}