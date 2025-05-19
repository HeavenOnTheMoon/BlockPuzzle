using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SquashDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("AdBtn")]    public Button UpSow;
[UnityEngine.Serialization.FormerlySerializedAs("NormalBtn")]    public Button DetachSow;
[UnityEngine.Serialization.FormerlySerializedAs("RewardText")]
    public Text SquashRail;
[UnityEngine.Serialization.FormerlySerializedAs("RewardObjs")]    public GameObject SquashStop;
    // Start is called before the first frame update
    void Start()
    {
        UpSow.onClick.AddListener(UpSowScene);
        DetachSow.onClick.AddListener(DetachSowScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public override void Display()
    {
        base.Display();
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Openboard);
        AbsenceUI();
        UpSow.enabled = true;
        DetachSow.enabled = true;
    }
    public override void Hidding()
    {
        base.Hidding();
        
        if(TraceEnrichTownLifelong.Instance.Lifelong == "ScratchcardReward")
            TraceEnrichTownLifelong.Instance.QualitativeSquash?.Invoke();
        if(TraceEnrichTownLifelong.Instance.Lifelong == "WheelReward")
            TraceEnrichTownLifelong.Instance.PerchSquash?.Invoke();
    }

    float rewardValue;
    string MakeupFirm;
    private void AbsenceUI()
    {
        for (int i = 0; i < SquashStop.transform.childCount; i++)
        {
            SquashStop.transform.GetChild(i).gameObject.SetActive(false);
        }
        rewardValue = float.Parse(FailWiseWorship.EraThrive(CBarter.My_SquashStick));
        MakeupFirm = FailWiseWorship.EraThrive(CBarter.My_SquashFirm);
        if (MakeupFirm == "cash")
        {
            SquashRail.text = rewardValue.ToString("f2");
            TuneTwine(rewardValue > PryTellOwn.instance.TownWise.CashLimit ? 2 : 3);
        }
        else
        {
            SquashRail.text = rewardValue.ToString("f0");
            TuneTwine(rewardValue > PryTellOwn.instance.TownWise.CoinLimit ? 0 : 1);
        }
    }

    private void TuneTwine(int index)
    {
        SquashStop.transform.GetChild(index).gameObject.SetActive(true);
    }

    private void UpSowScene()
    {
        UpSow.enabled = false;
        DetachSow.enabled = false;
        ADManager.Instance.playRewardVideo((success) =>
        {
            if (success)
            {
                //广告
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_doublereward);
                if (TraceEnrichTownLifelong.Instance.Lifelong == "ScratchcardReward")
                    TripGlassSevere.EraChlorine().RichGlass("1004", "1");
                else
                    TripGlassSevere.EraChlorine().RichGlass("1003", "1");
                SketchFossilize(SquashRail, rewardValue, () =>
                {
                    SquashRail.text = MakeupFirm == "cash" ? (rewardValue * 2).ToString("f2") : (rewardValue * 2).ToString("f0");

                    if (MakeupFirm == "cash")
                    {
                        TraceEnrichTownWiseWorship.EraChlorine().EelBriny(rewardValue * 2);
                    }
                    else
                    {
                        TraceEnrichTownWiseWorship.EraChlorine().EelRide(rewardValue * 2);
                    }
                    WheelUIPick(GetType().Name);
                });
            }
            else
            {
                UpSow.enabled = true;
                DetachSow.enabled = true;
            }
        }, TraceEnrichTownLifelong.Instance.Lifelong == "ScratchcardReward" ? "1" : "2");
        
    }

    private void DetachSowScene()
    {
        UpSow.enabled = false;
        DetachSow.enabled = false;
        if(TraceEnrichTownLifelong.Instance.Lifelong == "ScratchcardReward")
            TripGlassSevere.EraChlorine().RichGlass("1004", "0");
        else
            TripGlassSevere.EraChlorine().RichGlass("1003", "0");
        if (MakeupFirm == "cash")
        {
            TraceEnrichTownWiseWorship.EraChlorine().EelBriny(rewardValue);
        }
        else
        {
            TraceEnrichTownWiseWorship.EraChlorine().EelRide(rewardValue);
        }
        ADManager.Instance.NoThanksAddCount();
        WheelUIPick(GetType().Name);
    }
    
    public void SketchFossilize(Text text, float startNum, System.Action finish) 
    {
        text.transform.DOScale(2f, 0.3f).SetEase(Ease.OutBack).OnComplete(()=> 
        {
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_countup);
            if (MakeupFirm == "cash")
                DOTween.To(() => startNum, x => text.text = x.ToString("f2"), startNum * 2, 0.5f).OnComplete(() => 
                {
                    text.transform.DOScale(1f, 0.3f).SetDelay(1).OnComplete(()=>
                    {
                        finish();
                    });
                });
            else
                DOTween.To(() => startNum, x => text.text = x.ToString("f0"), startNum * 2, 0.5f).OnComplete(() => 
                {
                    text.transform.DOScale(1f, 0.3f).SetDelay(1).OnComplete(()=>
                    {
                        finish();
                    });
                });
        });
    }
}
