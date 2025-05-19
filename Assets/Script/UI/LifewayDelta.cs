using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifewayDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("Sound_Button")]    public Button Spend_Should;
[UnityEngine.Serialization.FormerlySerializedAs("Music_Button")]    public Button Agree_Should;
[UnityEngine.Serialization.FormerlySerializedAs("VibrationBtn")]    public Button PlausibleSow;
[UnityEngine.Serialization.FormerlySerializedAs("SoundIcon")]    public Sprite SpendMaya;
[UnityEngine.Serialization.FormerlySerializedAs("MusicIcon")]    public Sprite AgreeMaya;
[UnityEngine.Serialization.FormerlySerializedAs("VibrationIcon")]    public Sprite PlausibleMaya;
[UnityEngine.Serialization.FormerlySerializedAs("HomeBtn")]    public Button TwigSow;
[UnityEngine.Serialization.FormerlySerializedAs("BackBtn")]    public Button HallSow;
[UnityEngine.Serialization.FormerlySerializedAs("SoundOpenSprite")]    public Sprite SpendAbutSubway;
[UnityEngine.Serialization.FormerlySerializedAs("MusicOpenSprite")]    public Sprite AgreeAbutSubway;
[UnityEngine.Serialization.FormerlySerializedAs("VibrationOpenSprite")]    public Sprite PlausibleAbutSubway;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeSceneMask")]    public GameObject OutwitFlierFeat;
    public override void Display()
    {
        base.Display();
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Openboard);
        Agree_Should.GetComponent<Image>().sprite = AgreeOwn.EraChlorine().AtAgreeFusion ? AgreeMaya : AgreeAbutSubway;
        Spend_Should.GetComponent<Image>().sprite = AgreeOwn.EraChlorine().EscapeAgreeFusion ? SpendMaya : SpendAbutSubway;
        PlausibleSow.GetComponent<Image>().sprite = FailWiseWorship.EraKnow(CBarter.My_OnAstound) ? PlausibleMaya : PlausibleAbutSubway;
    }
    // Start is called before the first frame update
    void Start()
    {
        OutwitFlierFeat = UIWorship.EraChlorine().AnewGraham.transform.Find("Top/ChangeScene").gameObject;
        TwigSow.onClick.AddListener(() => {
            if (FailWiseWorship.EraThrive(CBarter.My_LifewayTwig) != "TwigDelta")
            {
                WheelUIPick(GetType().Name);
                TraceEnrichAnewWorship.instance.CannonTown();
                UIWorship.EraChlorine().TuneUIAware("TwigDelta");
                /*ChangeSceneMask.SetActive(true);
                ChangeSceneMask.GetComponent<OutwitFlier>().ChangeSceneAni(() => 
                {
                    CloseUIForm(GetType().Name);
                    TraceEnrichAnewWorship.instance.FinishGame();
                    UIWorship.GetInstance().ShowUIForms("TwigDelta");
                }, () =>
                {
                    
                });*/
            }
            else
            {
                WheelUIPick(GetType().Name);
            }
        });
        HallSow.onClick.AddListener(() => {
            WheelUIPick(GetType().Name);
        });
        
        Agree_Should.onClick.AddListener(() =>
        {

            AgreeOwn.EraChlorine().AtAgreeFusion = !AgreeOwn.EraChlorine().AtAgreeFusion;
            Agree_Should.GetComponent<Image>().sprite = AgreeOwn.EraChlorine().AtAgreeFusion ? AgreeMaya : AgreeAbutSubway;
        });
        Spend_Should.onClick.AddListener(() =>
        {

            AgreeOwn.EraChlorine().EscapeAgreeFusion = !AgreeOwn.EraChlorine().EscapeAgreeFusion;
            Spend_Should.GetComponent<Image>().sprite = AgreeOwn.EraChlorine().EscapeAgreeFusion ? SpendMaya : SpendAbutSubway;
        });
        PlausibleSow.onClick.AddListener((() =>
        {
            FailWiseWorship.FatKnow(CBarter.My_OnAstound, !FailWiseWorship.EraKnow(CBarter.My_OnAstound));
            PlausibleSow.GetComponent<Image>().sprite = FailWiseWorship.EraKnow(CBarter.My_OnAstound) ? PlausibleMaya : PlausibleAbutSubway;
        }));
    }

}
