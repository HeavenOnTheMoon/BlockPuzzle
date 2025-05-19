using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpWorshipSaleDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("LastPlayTimeCounterText")]    public Text LastLuceSureMeasureRail;
[UnityEngine.Serialization.FormerlySerializedAs("Counter101Text")]    public Text Measure101Rail;
[UnityEngine.Serialization.FormerlySerializedAs("Counter102Text")]    public Text Measure102Rail;
[UnityEngine.Serialization.FormerlySerializedAs("Counter103Text")]    public Text Measure103Rail;
[UnityEngine.Serialization.FormerlySerializedAs("TrialNumText")]    public Text SlaveJayRail;
[UnityEngine.Serialization.FormerlySerializedAs("PlayRewardedAdButton")]    public Button LuceOgallalaUpShould;
[UnityEngine.Serialization.FormerlySerializedAs("PlayInterstitialAdButton")]    public Button LuceIndifferenceUpShould;
[UnityEngine.Serialization.FormerlySerializedAs("NoThanksButton")]    public Button MeArcticShould;
[UnityEngine.Serialization.FormerlySerializedAs("TrialNumButton")]    public Button SlaveJayShould;
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    public Button WheelShould;
[UnityEngine.Serialization.FormerlySerializedAs("TimeInterstitialText")]    public Text SureIndifferenceRail;
[UnityEngine.Serialization.FormerlySerializedAs("PauseTimeInterstitialButton")]    public Button MajorSureIndifferenceShould;
[UnityEngine.Serialization.FormerlySerializedAs("ResumeTimeInterstitialButton")]    public Button MethylSureIndifferenceShould;

    private void Start()
    {
        InvokeRepeating(nameof(TuneMeasureRail), 0, 0.5f);

        WheelShould.onClick.AddListener(() => {
            WheelUIPick(GetType().Name);
        });

        LuceOgallalaUpShould.onClick.AddListener(() => {
            //ADManager.Instance.playRewardVideo((success) => { }, "10");
        });

        LuceIndifferenceUpShould.onClick.AddListener(() => {
            //ADManager.Instance.playInterstitialAd(1);
        });

        MeArcticShould.onClick.AddListener(() => {
            //ADManager.Instance.NoThanksAddCount();
        });

        SlaveJayShould.onClick.AddListener(() => {
            //ADManager.Instance.UpdateTrialNum(FailWiseWorship.GetInt(CBarter.sv_ad_trial_num) + 1);
            SlaveJayRail.text = FailWiseWorship.EraWit(CBarter.My_ad_Xenon_Nor).ToString();
        });

        MajorSureIndifferenceShould.onClick.AddListener(() => {
            //ADManager.Instance.PauseTimeInterstitial();
            TuneMajorSureIndifference();
        });

        MethylSureIndifferenceShould.onClick.AddListener(() => {
           // ADManager.Instance.ResumeTimeInterstitial();
            TuneMajorSureIndifference();
        });

    }

    public override void Display()
    {
        base.Display();
        SlaveJayRail.text = FailWiseWorship.EraWit(CBarter.My_ad_Xenon_Nor).ToString();
        TuneMajorSureIndifference();
    }

    private void TuneMeasureRail()
    {
       /* LastPlayTimeCounterText.text = ADManager.Instance.lastPlayTimeCounter.ToString();
        Counter101Text.text = ADManager.Instance.counter101.ToString();
        Counter102Text.text = ADManager.Instance.counter102.ToString();
        Counter103Text.text = ADManager.Instance.counter103.ToString();*/
    }

    private void TuneMajorSureIndifference()
    {
        //TimeInterstitialText.text = ADManager.Instance.pauseTimeInterstitial ? "已暂停" : "未暂停";
    }
}
