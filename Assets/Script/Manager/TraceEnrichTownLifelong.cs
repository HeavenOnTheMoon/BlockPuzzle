using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
public class TraceEnrichTownLifelong : MonoBehaviour
{
    public static TraceEnrichTownLifelong Instance;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeClearBlockStage")]    
    public Action OutwitBlameTraceBadly;
[UnityEngine.Serialization.FormerlySerializedAs("ClearBlock")]    public Action BlameTrace;
[UnityEngine.Serialization.FormerlySerializedAs("TargetBlockFly")]    public Action StrictTracePer;
[UnityEngine.Serialization.FormerlySerializedAs("WheelReward")]    public Action PerchSquash;
[UnityEngine.Serialization.FormerlySerializedAs("ScratchcardReward")]    public Action QualitativeSquash;
[UnityEngine.Serialization.FormerlySerializedAs("SourceReward")]    public Action AthensSquash;
[UnityEngine.Serialization.FormerlySerializedAs("GameFailed")]    public Action TownDampen;
[UnityEngine.Serialization.FormerlySerializedAs("GameSuccess")]    public Action TownCrowbar;
    //暂存棋子累计奖励
    
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("accumulateCount")]public int MineralizeCajun;

    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("CurCompleteWord")]public int LawFeldsparHind= 0;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("CurChapterSch")]public int LawTributeFur= 0;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("CurTotalChapter")]public int LawGooseTribute= 0;

    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("isHaveScratchCard")]public bool WeTestDormantWrap= false;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("isHaveScratchReward")]public bool WeTestDormantSquash= false;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("isHaveWheel")]public bool WeTestPerch= false;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("isHaveSource")]public bool WeTestAthens= false;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("Schedule")]public string Lifelong= "";
    private void Awake()
    {
        Instance = this;
    }

    public void PackSpank()
    {
        //accumulateCount++;
        
        //if (accumulateCount == 1 && (Schedule == "GameSuccess" || Schedule == "" || Schedule == "GameFailed"))
        {
            if(FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
                TownDelta.Instance.FeatSum.gameObject.SetActive(true);
            else
                TownSolidDelta.Instance.FeatSum.gameObject.SetActive(true);
            GameStartStep gameStartStep = new GameSchedules(null);
            GameStartStep nextStep = gameStartStep;
            nextStep = new ChangeClearBlockStage(nextStep);
            nextStep = new ClearBlock(nextStep);
            nextStep = new TargetBlockFly(nextStep);
            nextStep = new ScratchcardReward(nextStep);
            nextStep = new WheelReward(nextStep);
            nextStep = new SourceReward(nextStep);
            nextStep = new GameFailed(nextStep);
            nextStep = new GameSuccess(nextStep);
            gameStartStep.Onetime();
        }
    }
    // Start is called before the first frame update
    public void FatTownBulldoze()
    {
        
    }

    public void SureRisk(float time, Action finish)
    {
        StartCoroutine(SureRiskIE(time, finish));
    }
    public IEnumerator SureRiskIE(float time, Action finish)
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
    }
}

public class GameStartStep
{
    GameStartStep _LendGulf;
    private readonly Action _FamousStopHall;
    protected GameStartStep(GameStartStep previousStep)
    {
        if(previousStep != null)
            previousStep._LendGulf = this;
    }
    protected GameStartStep(GameStartStep previousStep, Action finishCallBack)
    {
        if (previousStep != null)
            previousStep._LendGulf = this;
        this._FamousStopHall = finishCallBack;
    }
    public virtual void Onetime()
    {
        
    }
    protected virtual void OnetimeCannon()
    {
        _FamousStopHall?.Invoke();
        DoTheyGulf();
    }
    protected void DoTheyGulf()
    {
        if (_LendGulf != null) 
        {
            _LendGulf.Onetime();

        }
        else
        {
            Debug.Log("特效进度完成");
            /*if (TraceEnrichTownLifelong.Instance.accumulateCount > 1)
            {
                TraceEnrichTownLifelong.Instance.accumulateCount = 1;
                TraceEnrichTownLifelong.Instance.GetChessReWard();
            }
            else if(TraceEnrichTownLifelong.Instance.accumulateCount == 1)
            {
                TraceEnrichTownLifelong.Instance.accumulateCount--;
            }*/
            /*if(TraceEnrichTownLifelong.Instance.accumulateCount == 0)
                TownDelta.Instance.MaskObj.gameObject.SetActive(false);*/
            //TraceEnrichTownLifelong.Instance.IsInit = true;
        }
    }
}

public class GameSchedules : GameStartStep
{
    public GameSchedules(GameStartStep nextStep) : base(nextStep)
    {
        
    }
    public override void Onetime()
    {
        TraceEnrichTownLifelong.Instance.FatTownBulldoze();
        OnetimeCannon();
    }

    protected override void OnetimeCannon()
    {
        base.OnetimeCannon();
        //Debug.Log("SetGameSettings Step Finish");
    }

}

public class ChangeClearBlockStage : GameStartStep
{
    public ChangeClearBlockStage(GameStartStep previousStep) : base(previousStep)
    {
    }
    public ChangeClearBlockStage(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Onetime()
    {
        TraceEnrichTownLifelong.Instance.Lifelong = "ChangeClearBlockStage";
        Debug.Log(TraceEnrichTownLifelong.Instance.Lifelong);
        TraceEnrichTownLifelong.Instance.OutwitBlameTraceBadly = OnetimeCannon;
        //直接计算好全部的奖励，这次发不发
        TraceEnrichGypsySaladWorship.Instance.OutwitBisBlameTrace();
        TraceEnrichGypsySaladWorship.Instance.EraSquashObvious();

    }
    
    protected override void OnetimeCannon()
    {
        DoTheyGulf();
    } 
}

public class ClearBlock : GameStartStep
{

    public ClearBlock(GameStartStep previousStep) : base(previousStep)
    {
    }
    public ClearBlock(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Onetime()
    {
        TraceEnrichTownLifelong.Instance.Lifelong = "ClearBlock";
        Debug.Log(TraceEnrichTownLifelong.Instance.Lifelong);
        TraceEnrichTownLifelong.Instance.BlameTrace = OnetimeCannon;
        TraceEnrichGypsySaladWorship.Instance.BlameTracePin();

    }
    
    protected override void OnetimeCannon()
    {
        DoTheyGulf();
    } 
}

public class TargetBlockFly : GameStartStep
{
    public TargetBlockFly(GameStartStep previousStep) : base(previousStep)
    {
    }
    public TargetBlockFly(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Onetime()
    {
        TraceEnrichTownLifelong.Instance.Lifelong = "TargetBlockFly";
        Debug.Log(TraceEnrichTownLifelong.Instance.Lifelong);
        TraceEnrichTownLifelong.Instance.StrictTracePer = OnetimeCannon;
        if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
            TraceEnrichGypsySaladWorship.Instance.PerStrictTrace();
        else
            TraceEnrichTownLifelong.Instance.StrictTracePer?.Invoke();
    }
    
    protected override void OnetimeCannon()
    {
        DoTheyGulf();
    } 
}


public class ScratchcardReward : GameStartStep
{
    public ScratchcardReward(GameStartStep previousStep) : base(previousStep)
    {
    }
    public ScratchcardReward(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Onetime()
    {
        TraceEnrichTownLifelong.Instance.Lifelong = "ScratchcardReward";
        Debug.Log(TraceEnrichTownLifelong.Instance.Lifelong);
        TraceEnrichTownLifelong.Instance.QualitativeSquash = OnetimeCannon;
        if (TraceEnrichTownLifelong.Instance.WeTestDormantWrap && !OliverFlaw.OnCycle() && FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
        {
            TraceEnrichAnewWorship.instance.TuneDormantWrapDelta();
        }
        else if (TraceEnrichTownLifelong.Instance.WeTestDormantSquash && !OliverFlaw.OnCycle() && FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
        {
            
        }
        else
        {
            TraceEnrichTownLifelong.Instance.QualitativeSquash?.Invoke();
        }
        
    }
    
    protected override void OnetimeCannon()
    {
        DoTheyGulf();
    } 
}

public class WheelReward : GameStartStep
{
    public WheelReward(GameStartStep previousStep) : base(previousStep)
    {
    }
    public WheelReward(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Onetime()
    {
        TraceEnrichTownLifelong.Instance.Lifelong = "WheelReward";
        Debug.Log(TraceEnrichTownLifelong.Instance.Lifelong);
        TraceEnrichTownLifelong.Instance.PerchSquash = OnetimeCannon;
        if (TraceEnrichTownLifelong.Instance.WeTestPerch && !OliverFlaw.OnCycle() && FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
        {
            TraceEnrichAnewWorship.instance.TunePerchDelta();
        }
        else
        {
            TraceEnrichTownLifelong.Instance.PerchSquash?.Invoke();
        }
        //WordHikeCheckerboardManager.instance.RefreshChallengeWord();
        
    }
    
    protected override void OnetimeCannon()
    {
        DoTheyGulf();
    } 
}


public class SourceReward : GameStartStep
{
    public SourceReward(GameStartStep previousStep) : base(previousStep)
    {
    }
    public SourceReward(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Onetime()
    {
        TraceEnrichTownLifelong.Instance.Lifelong = "SourceReward";
        Debug.Log(TraceEnrichTownLifelong.Instance.Lifelong);
        TraceEnrichTownLifelong.Instance.AthensSquash = OnetimeCannon;
        if (TraceEnrichTownLifelong.Instance.WeTestAthens)
        {
            TraceEnrichTownLifelong.Instance.WeTestAthens = false;
            TraceEnrichAthensWorship.Instance.TuneAthensDelta();
        }
        else
        {
            TraceEnrichTownLifelong.Instance.AthensSquash?.Invoke();
        }
    }
    
    protected override void OnetimeCannon()
    {
        DoTheyGulf();
    } 
}

public class GameSuccess : GameStartStep
{
    public GameSuccess(GameStartStep previousStep) : base(previousStep)
    {
    }
    public GameSuccess(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Onetime()
    {
        if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
        {
            TownDelta.Instance.FeatSum.gameObject.SetActive(true);
            TraceEnrichTownLifelong.Instance.Lifelong = "GameSuccess";
            Debug.Log(TraceEnrichTownLifelong.Instance.Lifelong);
            TraceEnrichTownLifelong.Instance.TownCrowbar = OnetimeCannon;
            if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "Guide")
            {
            
            }
            else if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "challenge" && TraceEnrichParisWorship.Instance.OutwitCrowbar() 
                || FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "Classic" && FailWiseWorship.EraKnow(CBarter.My_SomehowBylaw))
            {
                TownDelta.Instance.TraceLiterStop.GetComponent<CanvasGroup>().DOFade(0, 0.3f);
                TownDelta.Instance.RefuteLow.GetComponent<CanvasGroup>().DOFade(0, 0.3f);
                double Value = 0;
                var Wish= TraceEnrichAnewWorship.instance.EraSquashFirm(PryTellOwn.instance.TownWise.SuccessInfo);
                if (Wish.type == "cash")
                {
                    Value = BlockPuzzleGameUtil.GetCashMulti() * double.Parse(Wish.multiple);
                }
                else
                {
                    Value = BlockPuzzleGameUtil.GetGoldMulti() * double.Parse(Wish.multiple);
                }
                FailWiseWorship.FatThrive("SuccessInfoType", Wish.type);
                FailWiseWorship.FatPotato("SuccessInfoValue", Value);
                TownDelta.Instance.ParisCrowbar(true, () => 
                {
                    //胜利
                    //Debug.LogError("胜利");
                    TraceEnrichTownLifelong.Instance.Lifelong = "";
                    FailWiseWorship.FatThrive(CBarter.My_CannonBadly, "success");
                    // 游戏胜利动画
                    TraceEnrichGypsySaladWorship.Instance.TuneSawPin(() =>
                    {
                        UIWorship.EraChlorine().TuneUIAware("CannonDelta");
                        TraceEnrichAnewWorship.instance.TownCrowbar();
                    });
                });
            }
            else
            {
                TraceEnrichTownLifelong.Instance.TownCrowbar?.Invoke();
                TownDelta.Instance.FeatSum.gameObject.SetActive(false);
            }
        }
        else
        {
            TownSolidDelta.Instance.FeatSum.gameObject.SetActive(false);
            AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_OutwitSolidTownBulb);
        }
           
           
    }
    
    protected override void OnetimeCannon()
    {
        DoTheyGulf();
    } 
}

public class GameFailed : GameStartStep
{
    public GameFailed(GameStartStep previousStep) : base(previousStep)
    {
    }
    public GameFailed(GameStartStep previousStep, Action finishCallBack) : base(previousStep, finishCallBack)
    {
    }
    
    public override void Onetime()
    {
        TraceEnrichTownLifelong.Instance.Lifelong = "GameFailed";
        Debug.Log(TraceEnrichTownLifelong.Instance.Lifelong);
        TraceEnrichTownLifelong.Instance.TownDampen = OnetimeCannon;
        if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
        {
            TraceEnrichTraceWorship.Instance.OutwitBisBrief();
            TraceEnrichTraceWorship.Instance.OutwitDampen();
        }
        else
        {
            TraceEnrichTownLifelong.Instance.TownDampen?.Invoke();
        }
        
        
    }
    
    protected override void OnetimeCannon()
    {
        DoTheyGulf();
    } 
}
