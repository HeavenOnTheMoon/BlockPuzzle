using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FannerDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("SchImage")]
    public Image FurTwine;
[UnityEngine.Serialization.FormerlySerializedAs("AdBtn")]    public Button UpSow;
[UnityEngine.Serialization.FormerlySerializedAs("ReviveText")]    public TextMeshProUGUI FannerRail;
    // Start is called before the first frame update
    void Start()
    {
        UpSow.onClick.AddListener(UpSowScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public override void Display()
    {
        base.Display();
        FailWiseWorship.FatKnow(CBarter.My_OnFanner, true);
        Park = 5;
        FurTwine.fillAmount = 1;
        FannerRail.text = Park.ToString();
        StartCoroutine(CajunKier());
    }

    int Park= 0;
    
    IEnumerator CajunKier()
    {
        while (Park >= 0)
        {
            switch (Park)
            {
                case 5 : DOTween.To(() => FurTwine.fillAmount, x => FurTwine.fillAmount = x,  0.8f, 1.0f).SetEase(Ease.Linear).OnComplete(() => { }); break;
                case 4 : DOTween.To(() => FurTwine.fillAmount, x => FurTwine.fillAmount = x,  0.6f, 1.0f).SetEase(Ease.Linear).OnComplete(() => { }); break;
                case 3 : DOTween.To(() => FurTwine.fillAmount, x => FurTwine.fillAmount = x,  0.4f, 1.0f).SetEase(Ease.Linear).OnComplete(() => { }); break;
                case 2 : DOTween.To(() => FurTwine.fillAmount, x => FurTwine.fillAmount = x,  0.2f, 1.0f).SetEase(Ease.Linear).OnComplete(() => { }); break;
                case 1 : DOTween.To(() => FurTwine.fillAmount, x => FurTwine.fillAmount = x,  0f, 1.0f).SetEase(Ease.Linear).OnComplete(() => { }); break;
            }
            yield return new WaitForSeconds(1);
            Park--;
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Countdown);
            if (Park < 0)
            {
                WheelUIPick(GetType().Name);
                yield return new WaitForSeconds(0.2f);
                TraceEnrichTraceWorship.Instance.TownAsiaTracePin();
            }
                
            else
                FannerRail.text = Park.ToString();
        }
    }
    public override void Hidding()
    {
        base.Hidding();
        
    }

    private void UpSowScene()
    {
        ADManager.Instance.playRewardVideo((success) =>
        {
            if (success)
            {
                //广告
                WheelUIPick(GetType().Name);
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Revive);
                TraceEnrichTraceWorship.Instance.DampenFanner();
            }
            else
            {

            }
        }, "5");
        
    }
}
