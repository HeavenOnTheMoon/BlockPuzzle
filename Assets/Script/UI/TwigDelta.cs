using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwigDelta : TineUIAware
{
    public static TwigDelta instance;
[UnityEngine.Serialization.FormerlySerializedAs("ChallengeBtn")]    public Button VigilanceSow;
[UnityEngine.Serialization.FormerlySerializedAs("ClassicBtn")]    public Button SomehowSow;
[UnityEngine.Serialization.FormerlySerializedAs("ClassicBtnText")]    public Text SomehowSowRail;
[UnityEngine.Serialization.FormerlySerializedAs("NoClassicBtn")]    public Button MeSomehowSow;
[UnityEngine.Serialization.FormerlySerializedAs("SettingBtn")]    public Button LifewaySow;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeSceneMask")]    public GameObject OutwitFlierFeat;

    void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        bool showAdvernture = PryTellOwn.instance.TownWise.ShowAdventure;
        VigilanceSow.gameObject.SetActive(showAdvernture);
        SomehowSowRail.text = showAdvernture ? "Classic" : "PLAY";
        if (!showAdvernture)
        {
            SomehowSow.GetComponent<RectTransform>().localPosition = VigilanceSow.GetComponent<RectTransform>().localPosition - new Vector3(0, 100, 0);
        }

        LifewaySow.onClick.AddListener(() =>
        {
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_UIButton);
            FailWiseWorship.FatThrive(CBarter.My_LifewayTwig,"TwigDelta");
            UIWorship.EraChlorine().TuneUIAware("LifewayDelta");
        });
		VigilanceSow.onClick.AddListener(VigilanceSowScene);
		OutwitFlierFeat = UIWorship.EraChlorine().AnewGraham.transform.Find("Top/ChangeScene").gameObject;
        SomehowSow.onClick.AddListener(() =>
        {
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_UIButton);
            SomehowSow.enabled = false;
            FailWiseWorship.FatThrive(CBarter.My_LawTownDrum,"Classic");
            AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_WheelAndComSolid);
            //ChangeSceneMask.SetActive(true);
            SomehowSow.enabled = true;
           UIWorship.EraChlorine().TuneUIAware(OliverFlaw.TownBull());
            WheelUIPick(GetType().Name);
            /*ChangeSceneMask.GetComponent<OutwitFlier>().ChangeSceneAni(() => 
            {
                ClassicBtn.enabled = true;
                UIWorship.EraChlorine().ShowUIForms("TownDelta");
                
                    
            }, () => 
            {
                CloseUIForm(GetType().Name);
            });*/
        });
        
        MeSomehowSow.onClick.AddListener((() =>
        {
            LeafyWorship.EraChlorine().TuneLeafy("Unlock at Level " + (PryTellOwn.instance.TownWise.Unlock_classic + 1));
        }));
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void VigilanceSowScene()
    {
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_UIButton);
        VigilanceSow.enabled = false;
        FailWiseWorship.FatThrive(CBarter.My_LawTownDrum,"challenge");
        //ChangeSceneMask.SetActive(true);
        UIWorship.EraChlorine().TuneUIAware("TownDelta"); 
        WheelUIPick(GetType().Name);
        /*ChangeSceneMask.GetComponent<OutwitFlier>().ChangeSceneAni(() => 
        {
            UIWorship.EraChlorine().ShowUIForms("TownDelta");
        }, () => 
        {
            CloseUIForm(GetType().Name);
        });*/
    }
    
    public override void Display()
    {
        base.Display();

        VigilanceSow.enabled = true;
        SomehowSow.enabled = true;
        if (OliverFlaw.OnCycle())
        {
            //UIWorship.EraChlorine().ShowUIForms("SolidDelta");
        }
        if (TraceEnrichParisWorship.Instance.EraLawParis() >= PryTellOwn.instance.TownWise.Unlock_classic)
        {
            MeSomehowSow.gameObject.SetActive(false);
        }
    }
    public override void Hidding()
    {
        base.Hidding();
        
    }
}
