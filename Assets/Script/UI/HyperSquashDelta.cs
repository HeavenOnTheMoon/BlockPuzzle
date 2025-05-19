using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using LitJson;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HyperSquashDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("AdBtn")]    public Button UpSow;
[UnityEngine.Serialization.FormerlySerializedAs("NormalBtn")]    public Button DetachSow;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public Text FareRail;
[UnityEngine.Serialization.FormerlySerializedAs("SchText")]    public TextMeshProUGUI FurRail;
[UnityEngine.Serialization.FormerlySerializedAs("TittleText")]    public Text AttireRail;
[UnityEngine.Serialization.FormerlySerializedAs("LittleSchText")]    public Text LittleFurRail;
[UnityEngine.Serialization.FormerlySerializedAs("SchImage")]    public Image FurTwine;
[UnityEngine.Serialization.FormerlySerializedAs("SchTwoImage")]    public Image FurPigTwine;
[UnityEngine.Serialization.FormerlySerializedAs("CashImage")]    public Image FareTwine;
[UnityEngine.Serialization.FormerlySerializedAs("CoinImage")]    public Image DeemTwine;
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

    float Value = 0;
    public override void Display()
    {
        base.Display();
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Openboard);
        UpSow.enabled = true;
        DetachSow.enabled = true;
        var Wish= TraceEnrichAthensWorship.Instance.GooseEarner[TraceEnrichAthensWorship.Instance.EraWiseIDDelft(DateTime.Now)];
        switch (TraceEnrichAthensWorship.Instance.EarnerSquashID)
        {
            case 0 :
                AttireRail.text = "Conscious";
                LittleFurRail.text = "Brain activated to 25% and you won gold rewards!";
                Value = PryTellOwn.instance.TownWise.SourceRewards.oneQuarter;
                Wish.OftSquash = true;
                break;
            case 1 :
                AttireRail.text = "Clever";
                LittleFurRail.text = "Brain activated to 50% and you won gold rewards!";
                Value = PryTellOwn.instance.TownWise.SourceRewards.twoQuarter;
                Wish.PigSquash = true;
                break;
            case 2 :
                AttireRail.text = "Brain";
                LittleFurRail.text = "Brain activated to 75% and you won gold rewards!";
                Value = PryTellOwn.instance.TownWise.SourceRewards.threeQuarter;
                Wish.TrackSquash = true;
                break;
            case 3 :
                AttireRail.text = "Genius";
                LittleFurRail.text = "Brain activated to 100% and you won gold rewards!";
                Value = PryTellOwn.instance.TownWise.SourceRewards.fourQuarter;
                Wish.AfarSquash = true;
                break;
        }
        FareTwine.gameObject.SetActive(!OliverFlaw.OnCycle());
        DeemTwine.gameObject.SetActive(OliverFlaw.OnCycle());
        if (OliverFlaw.OnCycle())
            Value = 1000;

        FareRail.text = Value.ToString();
        
        float Beg= (float)Wish.Athens / PryTellOwn.instance.TownWise.SourceRewards.dailyMaxSource;
        FurRail.text = (Beg * 100).ToString("f0") + "%";
        FurTwine.fillAmount = Beg;
        //SchTwoImage.fillAmount = sch;
        TraceEnrichAthensWorship.Instance.GooseEarner[TraceEnrichAthensWorship.Instance.EraWiseIDDelft(DateTime.Now)] = Wish;
        //FailWiseWorship.SetString(CBarter.sv_MentalSourceInfo, JsonMapper.ToJson(info));
        FailWiseWorship.FatThrive(CBarter.My_EarnerAthensTell, JsonMapper.ToJson(TraceEnrichAthensWorship.Instance.GooseEarner));
    }
    public override void Hidding()
    {
        base.Hidding();
        
        TraceEnrichTownLifelong.Instance.AthensSquash?.Invoke();
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
                TripGlassSevere.EraChlorine().RichGlass("1005", TraceEnrichAthensWorship.Instance.EarnerSquashID.ToString(), "1");

                SketchFossilize(FareRail, Value, () =>
                {
                    FareRail.text = (Value * 2).ToString("f0");
                    if (OliverFlaw.OnCycle())
                        TraceEnrichTownWiseWorship.EraChlorine().EelRide(Value * 2);
                    else
                        TraceEnrichTownWiseWorship.EraChlorine().EelBriny(Value * 2);
                    WheelUIPick(GetType().Name);
                });
            }
            else
            {
                UpSow.enabled = true;
                DetachSow.enabled = true;
            }
        }, "4");
        
    }

    private void DetachSowScene()
    {
        UpSow.enabled = false;
        DetachSow.enabled = false;
        TripGlassSevere.EraChlorine().RichGlass("1005", TraceEnrichAthensWorship.Instance.EarnerSquashID.ToString(),"0");
        if (OliverFlaw.OnCycle())
            TraceEnrichTownWiseWorship.EraChlorine().EelRide(Value);
        else
            TraceEnrichTownWiseWorship.EraChlorine().EelBriny(Value);
        ADManager.Instance.NoThanksAddCount();
        WheelUIPick(GetType().Name);
    }
    
    public void SketchFossilize(Text text, float startNum, System.Action finish) 
    {
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_countup);
        text.transform.DOScale(2f, 0.3f).SetEase(Ease.OutBack).OnComplete(()=> 
        {
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
