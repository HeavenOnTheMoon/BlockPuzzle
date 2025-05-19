using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
public class TraceEnrichAnewWorship : MonoBehaviour
{
    public static TraceEnrichAnewWorship instance;

    private bool Towel= false;

    private void Awake()
    {
        
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }
[UnityEngine.Serialization.FormerlySerializedAs("today")]    public DateTime Decor;
    public void BiteRake()
    {
        Decor = DateTime.Now;
        TripGlassSevere.EraChlorine().RichGlass("1001");
        Application.targetFrameRate = 60;
        bool isNewPlayer = !PlayerPrefs.HasKey(CBarter.My_OnNewStudio + "Bool") || FailWiseWorship.EraKnow(CBarter.My_OnNewStudio);
        if (isNewPlayer)
        {
            // 新用户
            FailWiseWorship.FatKnow(CBarter.My_OnNewStudio, false);
            FailWiseWorship.FatWit(CBarter.My_GlassDormantWrap, 0);
            FailWiseWorship.FatKnow(CBarter.My_OnAstound, true);
            FailWiseWorship.FatWit(CBarter.My_SolidTownBulb,99);
        }
        //换天清空
        if (FailWiseWorship.EraWit(CBarter.My_EyeDugoutRender) == 0 || Decor.Day != FailWiseWorship.EraWit(CBarter.My_EyeDugoutRender))
        {
            FailWiseWorship.FatWit(CBarter.My_EyeDugoutRender, Decor.Day);
            FailWiseWorship.FatWit(CBarter.My_IdiomAthensCajun, 0);
        }
        if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) != 99)
        {
            FailWiseWorship.FatWit(CBarter.My_SolidTownBulb, TraceEnrichParisWorship.Instance.EraLawParis() >= 1 ? 99 : 0);
        }
            
        TraceEnrichAthensWorship.Instance.AbsenceAthensSquash();
        AgreeOwn.EraChlorine().LuceAt(AgreeFirm.SceneMusic.Sound_BGM);

        //UIWorship.GetInstance().ShowUIForms("TownDelta");
        if (SceneManager.GetActiveScene().name == "CreatBlockScene")
        {
            UIWorship.EraChlorine().TuneUIAware("LowerParisDelta");
        }
        else
        {
            if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 0)
                UIWorship.EraChlorine().TuneUIAware("TownSolidDelta");
            else
                UIWorship.EraChlorine().TuneUIAware("TwigDelta");
        }

        TraceEnrichTownWiseWorship.EraChlorine().RakeTownWise();
        Towel = true;

    }

    #region Wheel

    public void BoxPerchFur()
    {
        var oldCount = FailWiseWorship.EraWit(CBarter.My_PerchCajun);
        var newCount = OutwitPerchSquash(oldCount);
        FailWiseWorship.FatWit(CBarter.My_PerchCajun, newCount);

        int oldWheelReward = FailWiseWorship.EraWit(CBarter.My_PerchSquash);
        double rewardValue = 0;
        if (oldWheelReward < 2)
        {
            // 如果转盘奖励进度之前为0或1，计算奖励
            int MakeupCajun= (oldWheelReward + 1) * PryTellOwn.instance.TownWise.WheelReward.ShowCount;    // 下一次奖励需要的放置积木次数
            if (oldCount < MakeupCajun && newCount >= MakeupCajun)
            {
                if (PryTellOwn.instance.TownWise.WheelReward.Reward[0].type == "cash")
                {
                    rewardValue = BlockPuzzleGameUtil.GetCashMulti() * double.Parse(PryTellOwn.instance.TownWise.WheelReward.Reward[0].multiple);
                }
                else
                {
                    rewardValue = BlockPuzzleGameUtil.GetGoldMulti() * double.Parse(PryTellOwn.instance.TownWise.WheelReward.Reward[0].multiple);
                }
                FailWiseWorship.FatWit(CBarter.My_PerchSquash, oldWheelReward + 1);
                TownDelta.Instance.FeatSum.SetActive(true);
                TraceEnrichTownLifelong.Instance.WeTestDormantSquash = true;
            }
            else
            {
                TraceEnrichTownLifelong.Instance.WeTestDormantSquash = false;
            }
        }
        else
        {
            TraceEnrichTownLifelong.Instance.WeTestDormantSquash = false;
        }
        AnemoneWise md = new AnemoneWise(oldWheelReward);
        md.OlivePotato = rewardValue;
        AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_PerchUI, md);
    }

    public void BlamePerchFur()
    {
        FailWiseWorship.FatWit(CBarter.My_PerchCajun, 0);
        FailWiseWorship.FatWit(CBarter.My_PerchSquash, 0);
        AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_PerchUI, new AnemoneWise(0));
    }

    public int OutwitPerchSquash(int oldCount)
    {
        int newCount = oldCount + 1;
        int oldWheelReward = FailWiseWorship.EraWit(CBarter.My_PerchSquash);
        int MakeupCajun= (oldWheelReward + 1) * PryTellOwn.instance.TownWise.WheelReward.ShowCount;
        //可以触发奖励
        if (newCount >= MakeupCajun && oldCount < MakeupCajun)
        {
            //存在刮刮卡奖励
            if (TraceEnrichTownLifelong.Instance.WeTestDormantWrap)
            {
                //下次操作必定获得奖励
                TraceEnrichTownLifelong.Instance.WeTestPerch = false;
                return newCount - 1;
            }
            else
            {
                TraceEnrichTownLifelong.Instance.WeTestPerch = oldWheelReward == 2;
                return newCount;
            }
        }
        else
        {
            //不足
            TraceEnrichTownLifelong.Instance.WeTestPerch = false;
            return newCount;
        }
    }
    
    public void TunePerchDelta()
    {
        StartCoroutine(Seashell(0.6f, (() =>
        {
            UIWorship.EraChlorine().TuneUIAware("ImagePerchDelta");
            FailWiseWorship.FatWit(CBarter.My_PerchCajun, FailWiseWorship.EraWit(CBarter.My_PerchCajun) - PryTellOwn.instance.TownWise.WheelReward.ShowCount);
        })));
        
        //TraceEnrichTownLifelong.Instance.WheelReward?.Invoke();
        //UIWorship.GetInstance().ShowUIForms("ImagePerchDelta");
    }

    IEnumerator Seashell(float time, Action finish)
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
    }

    public int EraPerchFur()
    {
        return FailWiseWorship.EraWit(CBarter.My_PerchCajun);
    }

  #endregion

    #region ScratchCard

    public void TuneDormantWrapDelta()
    {
        /*TraceEnrichGypsySaladWorship.Instance.ScratchObjs.transform.DOScale(0, 0.3f).SetEase(Ease.InBack).SetDelay(0.2f).OnComplete(() =>
        {
            Destroy(TraceEnrichGypsySaladWorship.Instance.ScratchObjs);
            UIWorship.GetInstance().ShowUIForms("QualitativeDelta");
            //TraceEnrichGypsySaladWorship.Instance.ScratchObjs = new GameObject();
        });*/
        for (int k = 0; k < TownDelta.Instance.TraceSP.Count; k++)
        {
            GameObject Item = TownDelta.Instance.TraceSP[k].gameObject;
            if (Item != null)
            {
                //Debug.Log("QualitativeDelta == " + Item.GetComponent<TraceEnrichTraceRender>().Type);
                if (Item.GetComponent<TraceEnrichTraceRender>().Type == 99)
                    Item.transform.DOScale(0, 0.3f).SetEase(Ease.InBack).SetDelay(0.2f).OnComplete(() =>
                    {
                        Destroy(Item);
                        UIWorship.EraChlorine().TuneUIAware("QualitativeDelta");
                    });
            }
        }
        
    }

  #endregion

    public void TownCrowbar()
    {
        if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "challenge")
        {
            //弹出对应游戏奖励页面，后续刷新棋盘信息
            TraceEnrichParisWorship.Instance.BoxParis();
            TraceEnrichParisWorship.Instance.EraLawParisTell();
            TraceEnrichParisWorship.Instance.RakeStrict();
        }
        else
        {
            
        }
        //刷新棋盘
        //TraceEnrichGypsySaladWorship.Instance.RefreshCheckBoard();
    }

    public void TownDampen()
    {
        if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "challenge")
        {
            TraceEnrichTownLifelong.Instance.MineralizeCajun = 0;
            FailWiseWorship.FatThrive(CBarter.My_CannonBadly, "failed");
            UIWorship.EraChlorine().TuneUIAware("CannonDelta");
        }
        else
        {
            TraceEnrichTownLifelong.Instance.MineralizeCajun = 0;
            if (FailWiseWorship.EraWit(CBarter.My_LawAthensCajun) == FailWiseWorship.EraWit(CBarter.My_RimAthensCajun))
            {
                FailWiseWorship.FatThrive(CBarter.My_CannonBadly, "bestChallenge");
            }
            else
            {
                FailWiseWorship.FatThrive(CBarter.My_CannonBadly, "Challenge");
            }
            
            UIWorship.EraChlorine().TuneUIAware("CannonDelta");
        }
    }

    public MultiplierBox EraCrossbreed(List<MultiplierBox> rewardInfos)
    {
        int sum = 0;
        if (sum == 0)
        {
            for (int i = 0; i < rewardInfos.Count; i++)
            {
                sum += rewardInfos[i].weight;
            }
        }

        int rewardRandom = Random.Range(0, 999);
        float Shun= 0;
        for (int i = 0; i < rewardInfos.Count; i++)
        {
            Shun += rewardInfos[i].weight / (float)sum;
            if (rewardRandom <= Shun * 1000)
            {
                return rewardInfos[i];
            }
        }
        return rewardInfos[0];
    }
    
    /// <summary>
    /// 获取奖励类型
    /// </summary>
    /// <param name="rewardInfos"></param>
    /// <returns></returns>
    public RewardItem EraSquashFirm(List<RewardItem> rewardInfos)
    {
        if (OliverFlaw.OnCycle())
        {
            foreach (RewardItem t in rewardInfos.Where(t => t.type == "coin"))
            {
                return t;
            }
        }
        int sum = 0;
        if (sum == 0)
        {
            for (int i = 0; i < rewardInfos.Count; i++)
            {
                sum += rewardInfos[i].weight;
            }
        }

        int rewardRandom = Random.Range(0, 999);
        float Shun= 0;
        for (int i = 0; i < rewardInfos.Count; i++)
        {
            Shun += rewardInfos[i].weight / (float)sum;
            if (rewardRandom <= Shun * 1000)
            {
                return rewardInfos[i];
            }
        }
        return rewardInfos[0];
    }
    
    public int EraBoxCajun(double StartCount, double EndCount, bool isCash)
    {
        double difference = Math.Abs(EndCount - StartCount);
        if (isCash)
        {
            if (difference < PryTellOwn.instance.TownWise.CashLimit)
            {
                return 1;
            }
            else
            {
                return ((int)(difference / PryTellOwn.instance.TownWise.CashLimit)) + 1;
            }
        }
        else
        {
            if (difference < 1000)
            {
                return 1;
            }
            else
            {
                return ((int)(difference / 1000)) + 1;
            }
        }
    }
    
    public int EraScrStick(List<ScraCount> rewardInfos)
    {
        int sum = 0;
        if (sum == 0)
        {
            for (int i = 0; i < rewardInfos.Count; i++)
            {
                sum += rewardInfos[i].weight;
            }
        }

        int rewardRandom = Random.Range(0, 999);
        float Shun= 0;
        for (int i = 0; i < rewardInfos.Count; i++)
        {
            Shun += rewardInfos[i].weight / (float)sum;
            if (rewardRandom <= Shun * 1000)
            {
                return rewardInfos[i].count;
            }
        }
        return 0;
    }

    public void CannonTown()
    {
        FailWiseWorship.FatWit(CBarter.My_GlassDormantWrap, 0);
        UIWorship.EraChlorine().WheelNoFinelyUIAware(OliverFlaw.TownBull());
        TraceEnrichAthensWorship.Instance.BlameTenon();
        for (int i = TraceEnrichTraceWorship.Instance.TraceLiterAllay.Count - 1; i >= 0; i--)
        {
            TraceEnrichTraceWorship.Instance.FloristTrace(TraceEnrichTraceWorship.Instance.TraceLiterAllay[i]);
        }
        
    }
    
    public int[] RetoolWit(int[] num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            var temp = num[i];
            int randomIndex = RetoolStick(0, num.Length);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        return num;
    }

    public List<T> RetoolPity<T>(List<T> num)
    {
        for (int i = 0; i < num.Count; i++)
        {
            var temp = num[i];
            int randomIndex = RetoolStick(0, num.Count);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        return num;
    }

    private int RetoolStick(int min, int max)
    {
        return Random.Range(min, max);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public bool OnBoxStick(int index)
    {
        var Create= RetoolStick(0, 1000);
        return (index < Create);
    }
    
    public void CanVasAstound()
    {
        if(FailWiseWorship.EraKnow(CBarter.My_OnAstound))
            Vibration.VibratePop();
    }
}