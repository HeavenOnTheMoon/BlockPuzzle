using System;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Spine.Unity;

public class CannonDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("ShowList")]    public List<GameObject> TunePity;
[UnityEngine.Serialization.FormerlySerializedAs("GoldButton")]    public Button RideShould;
[UnityEngine.Serialization.FormerlySerializedAs("TokenBtn")]    public Button BrinySow;
[UnityEngine.Serialization.FormerlySerializedAs("NextBtn")]    
    public Button TheySow;
[UnityEngine.Serialization.FormerlySerializedAs("FailedBtn")]    public Button DampenSow;
[UnityEngine.Serialization.FormerlySerializedAs("ChallengeRetayBtn")]    public Button VigilanceTotalSow;
[UnityEngine.Serialization.FormerlySerializedAs("HomeBtn")]    public Button TwigSow;
[UnityEngine.Serialization.FormerlySerializedAs("SuccessRewardImage")]
    //public Text SuccessLevelText;
    public Image CrowbarSquashTwine;
[UnityEngine.Serialization.FormerlySerializedAs("SuccessRewardText")]    public Text CrowbarSquashRail;
[UnityEngine.Serialization.FormerlySerializedAs("BoxRewardSlider")]    public int AxeSquashRunoff;//宝箱进度
[UnityEngine.Serialization.FormerlySerializedAs("BoxRewardSchObj")]    public List<GameObject> AxeSquashFurSum;
[UnityEngine.Serialization.FormerlySerializedAs("TargetObjs")]
    //public Text FailedLevelText;
    public List<GameObject> StrictStop;
[UnityEngine.Serialization.FormerlySerializedAs("ChallengeBestSourceText")]
    public Text VigilanceHailAthensRail;
[UnityEngine.Serialization.FormerlySerializedAs("CurChallengeSourceText")]    public Text LawVigilanceAthensRail;
[UnityEngine.Serialization.FormerlySerializedAs("CurChallengeSourceTwoText")]    public Text LawVigilanceAthensPigRail;
[UnityEngine.Serialization.FormerlySerializedAs("BestChallengeSourceTwoText")]    //最高分
    public Text HailVigilanceAthensPigRail;
[UnityEngine.Serialization.FormerlySerializedAs("ChallengeRewadImage")]
    public Image VigilanceTitleTwine;
[UnityEngine.Serialization.FormerlySerializedAs("ChallengeRewedText")]    public Text VigilanceAlterRail;
[UnityEngine.Serialization.FormerlySerializedAs("FX_Challenge")]
    public GameObject FX_Vigilance;
[UnityEngine.Serialization.FormerlySerializedAs("FX_FireWork")]    public GameObject FX_LoanYarn;
[UnityEngine.Serialization.FormerlySerializedAs("RewardChallengeCash")]    public GameObject SquashVigilanceFare;
[UnityEngine.Serialization.FormerlySerializedAs("PBGroup")]
    //public GameObject PBLight;
    //public GameObject PBLight;
    public GameObject PBLiter;
[UnityEngine.Serialization.FormerlySerializedAs("Ancu")]
    public AnimationCurve Beng;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeSceneMask")]
    public GameObject OutwitFlierFeat;
[UnityEngine.Serialization.FormerlySerializedAs("CoinText")]    
    public Text DeemRail;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public Text FareRail;
[UnityEngine.Serialization.FormerlySerializedAs("CashTF")]    public Transform FareTF;
[UnityEngine.Serialization.FormerlySerializedAs("CoinTF")]    public Transform DeemTF;
[UnityEngine.Serialization.FormerlySerializedAs("TopBar")]    public GameObject LipLow;
    // Start is called before the first frame update
    void Start()
    {
        RideShould.onClick.AddListener(() => {
            
        });
        BrinySow.transform.parent.gameObject.SetActive(!OliverFlaw.OnCycle());
        BrinySow.onClick.AddListener(() =>
        {
           
        });
        
        OutwitFlierFeat = UIWorship.EraChlorine().AnewGraham.transform.Find("Top/ChangeScene").gameObject;

        TheySow.onClick.AddListener((() =>
        {
            TheySow.enabled = false;
            ADManager.Instance.NoThanksAddCount();
            TuneOutwit((() =>
            {
                TheySow.enabled = true;
                WheelUIPick(GetType().Name);
                if (TraceEnrichTributeWorship.instance.EraFeldsparTributeBadly())
                    UIWorship.EraChlorine().TuneUIAware("VaporDelta");
                else
                    UIWorship.EraChlorine().TuneUIAware(OliverFlaw.TownBull());
                /*ChangeSceneMask.SetActive(true);
                ChangeSceneMask.GetComponent<OutwitFlier>().ChangeSceneAni(() => 
                {
                    NextBtn.enabled = true;
                    CloseUIForm(GetType().Name);
                    if(TraceEnrichTributeWorship.instance.GetCompleteChapterStage())
                        UIWorship.EraChlorine().ShowUIForms("VaporDelta");
                    else
                        UIWorship.EraChlorine().ShowUIForms("TownDelta");
                }, () => 
                {
                
                });*/
            }));
            
        }));
        
        DampenSow.onClick.AddListener((() =>
        {
            ADManager.Instance.NoThanksAddCount();
            TuneOutwit((() =>
            {
                WheelUIPick(GetType().Name);
                UIWorship.EraChlorine().TuneUIAware(OliverFlaw.TownBull());
                /*ChangeSceneMask.SetActive(true);
                ChangeSceneMask.GetComponent<OutwitFlier>().ChangeSceneAni(() => 
                {
                    CloseUIForm(GetType().Name);
                    UIWorship.EraChlorine().ShowUIForms("TownDelta");
                }, () => 
                {
                
                });*/
            }));
            
        }));
        
        VigilanceTotalSow.onClick.AddListener((() =>
        {
            ADManager.Instance.NoThanksAddCount();
            TuneOutwit(() =>
            {
                WheelUIPick(GetType().Name);
                UIWorship.EraChlorine().TuneUIAware(OliverFlaw.TownBull());
                /*ChangeSceneMask.SetActive(true);
                ChangeSceneMask.GetComponent<OutwitFlier>().ChangeSceneAni(() => 
                {
                    CloseUIForm(GetType().Name);
                    UIWorship.EraChlorine().ShowUIForms("TownDelta");
                }, () => 
                {
                
                });*/
            });
            
        }));
        
        TwigSow.onClick.AddListener((() =>
        {
            ADManager.Instance.NoThanksAddCount();
            TuneOutwit(() =>
            {
                WheelUIPick(GetType().Name);
                UIWorship.EraChlorine().TuneUIAware("TwigDelta");
                /*ChangeSceneMask.SetActive(true);
                ChangeSceneMask.GetComponent<OutwitFlier>().ChangeSceneAni(() =>
                {
                    CloseUIForm(GetType().Name);
                    UIWorship.EraChlorine().ShowUIForms("TwigDelta");
                }, () =>
                {

                });*/
            });

            //CloseUIForm(GetType().Name);
        }));
        
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_Up_Pigment, (messageData) =>
        {
            CardBoxFossilize(messageData.OliveExcursion, messageData.OlivePotato);
        });
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_Up_Director, (messageData) =>
        {
            UntilBoxFossilize(messageData.OliveExcursion, messageData.OlivePotato);
        });
    }

    private void TuneOutwit(Action finish)
    {
        StartCoroutine(SureRisk(0.2f, () =>
        {
            finish?.Invoke();
        }));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public override void Display()
    {
        base.Display();
        LipLow.SetActive(false);
        //FailedLevelText.text = "LEVEL " + (TraceEnrichParisWorship.Instance.GetCurLevel() + 1);
        //SuccessLevelText.text = "LEVEL " + (TraceEnrichParisWorship.Instance.GetCurLevel() + 1);
        DeemRail.text = (TraceEnrichTownWiseWorship.EraChlorine().RubRide().ToString("f0"));
        FareRail.text = BrightFlaw.PotatoIDGin(TraceEnrichTownWiseWorship.EraChlorine().RubBriny());
        TraceEnrichAnewWorship.instance.CannonTown();
        AbsenceUI();
        AbsenceStrictUI();
        float DelayTime = 0;
        int a = 0;
        var stage = FailWiseWorship.EraThrive(CBarter.My_CannonBadly);
        if (stage == "success")
        {
            ParisCannonFossilize(() =>
            {
                
            });
        }
        else
        {
            for (int i = 0; i < TunePity.Count; i++)
            {
                a = i;
                GameObject Fare= TunePity[i];
                Fare.transform.localScale = new Vector3(0, 0, 0);
                Fare.transform.DOScale(0.7f, 0.3f).SetDelay(DelayTime).SetEase(Ease.OutBack).OnComplete((() =>
                {
                }));
                DelayTime += 0.1f;
                if (a == TunePity.Count - 1)
                {

                }
            }
        }
        StartCoroutine(SureRisk(1.2f, () =>
        {
            var stage = FailWiseWorship.EraThrive(CBarter.My_CannonBadly);
            
            if (stage == "success")
            {
                TunePity[2].transform.GetChild(0).gameObject.SetActive(false);
                AxeSquashRunoff = (TraceEnrichParisWorship.Instance.EraLawParis()) % 5;
                if (AxeSquashRunoff == 0)
                    AxeSquashRunoff = 5;
                for (int i = 0; i < AxeSquashRunoff - 1; i++)
                {
                    if (i == AxeSquashRunoff - 1)
                    {
                        StartCoroutine(SureRisk(DelayTime + 0.5f, () => {
                            AxeSquashFurSum[i].SetActive(true);
                            AxeSquashFurSum[i].GetComponent<CanvasGroup>().alpha = 1;
                        }));
                    }
                    else
                    {
                        AxeSquashFurSum[i].SetActive(true);
                        AxeSquashFurSum[i].GetComponent<CanvasGroup>().alpha = 1;
                    }
                }
                StartCoroutine(AppointSquashAxe((() =>
                {
                    TunePity[2].transform.localScale = new Vector3(0, 0, 0);
                    //if (BoxRewardSlider != 5)
                    TunePity[2].transform.GetChild(0).gameObject.SetActive(true);
                    TunePity[2].transform.DOScale(0.7f, 0.3f).SetDelay(DelayTime).SetEase(Ease.OutBack).OnComplete((() =>
                    {
                    }));
                    
                })));
            }
            else if (stage == "bestChallenge" || stage == "Challenge")
            {
                if (stage == "bestChallenge")
                {
                    FX_LoanYarn.SetActive(true);
                }
                StartCoroutine(VigilancePin());
            }
        }));
    }
    
    

    double Value;
    int type;
    private void AbsenceUI()
    {
        var stage = FailWiseWorship.EraThrive(CBarter.My_CannonBadly);
        
        for (int i = 0; i < TunePity[0].transform.childCount - 1; i++)
            TunePity[0].transform.GetChild(i).gameObject.SetActive(false);
        
        for (int i = 0; i < TunePity[1].transform.childCount; i++)
            TunePity[1].transform.GetChild(i).gameObject.SetActive(false);
        
        for (int i = 0; i < TunePity[2].transform.childCount; i++)
            TunePity[2].transform.GetChild(i).gameObject.SetActive(false);
        var Wish= TraceEnrichAnewWorship.instance.EraSquashFirm(PryTellOwn.instance.TownWise.SuccessInfo);
        if (Wish.type == "cash")
        {
            Value = BlockPuzzleGameUtil.GetCashMulti() * double.Parse(Wish.multiple);
            if(stage != "success")
                Value = (float)FailWiseWorship.EraWit(CBarter.My_LawAthensCajun) / PryTellOwn.instance.TownWise.FinishLimit * Value;
            type = 0;
            CrowbarSquashTwine.sprite = FareTF.transform.GetComponent<Image>().sprite;
            VigilanceTitleTwine.sprite = FareTF.transform.GetComponent<Image>().sprite;
            CrowbarSquashRail.text = Value.ToString("f2");
            VigilanceAlterRail.text = Value.ToString("f2");
        }
        else
        {
            Value = BlockPuzzleGameUtil.GetGoldMulti() * double.Parse(Wish.multiple);
            if(stage != "success")
                Value = (float)FailWiseWorship.EraWit(CBarter.My_LawAthensCajun) / PryTellOwn.instance.TownWise.FinishLimit * Value;
            type = 1;
            CrowbarSquashTwine.sprite = DeemTF.transform.GetComponent<Image>().sprite;
            VigilanceTitleTwine.sprite = DeemTF.transform.GetComponent<Image>().sprite;
            CrowbarSquashRail.text = Value.ToString("f0");
            VigilanceAlterRail.text = Value.ToString("f0");
        }
        LawVigilanceAthensRail.text = FailWiseWorship.EraWit(CBarter.My_LawAthensCajun).ToString("f0");
        HailVigilanceAthensPigRail.text = FailWiseWorship.EraWit(CBarter.My_RimAthensCajun).ToString("f0");
        LawVigilanceAthensPigRail.text =FailWiseWorship.EraWit(CBarter.My_RimAthensCajun).ToString("f0"); 
        switch (stage)
        {
            case "success" :
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_CompleteLevel);
                TunePity[0].transform.GetChild(0).gameObject.SetActive(true);
                TunePity[1].transform.GetChild(0).gameObject.SetActive(true);
                //ShowList[2].transform.GetChild(0).gameObject.SetActive(true);
                
                break;
            case "failed" :
                TunePity[0].transform.GetChild(1).gameObject.SetActive(true);
                TunePity[1].transform.GetChild(1).gameObject.SetActive(true);
                TunePity[2].transform.GetChild(1).gameObject.SetActive(true);
                TunePity[2].transform.GetChild(3).gameObject.SetActive(true);
                break;
            case "bestChallenge" :
                TunePity[0].transform.GetChild(2).gameObject.SetActive(true);
                TunePity[1].transform.GetChild(2).gameObject.SetActive(true);
                TunePity[1].transform.GetChild(2).transform.GetChild(0).gameObject.SetActive(false);
                TunePity[1].transform.GetChild(2).transform.GetChild(1).gameObject.SetActive(true);
                TunePity[2].transform.GetChild(2).gameObject.SetActive(true);
                TunePity[2].transform.GetChild(3).gameObject.SetActive(true);
                TripGlassSevere.EraChlorine().RichGlass("1021", (FailWiseWorship.EraWit(CBarter.My_LawAthensCajun) / 1000 + 1).ToString());
                break;
            case "Challenge" :
                TunePity[0].transform.GetChild(3).gameObject.SetActive(true);
                TunePity[1].transform.GetChild(2).gameObject.SetActive(true);
                TunePity[1].transform.GetChild(2).transform.GetChild(0).gameObject.SetActive(true);
                TunePity[1].transform.GetChild(2).transform.GetChild(1).gameObject.SetActive(false);
                TunePity[2].transform.GetChild(2).gameObject.SetActive(true);
                TunePity[2].transform.GetChild(3).gameObject.SetActive(true);
                TripGlassSevere.EraChlorine().RichGlass("1021", (FailWiseWorship.EraWit(CBarter.My_LawAthensCajun) / 1000 + 1).ToString());
                break;
        }
        SquashVigilanceFare.SetActive(false);
        FX_LoanYarn.SetActive(false);
        SquashVigilanceFare.transform.localScale = new Vector3(0, 0, 0);
    }
    
    /// <summary>
    /// 刷新进度条
    /// </summary>
    public IEnumerator AppointSquashAxe(Action finish) 
    {
        //yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < AxeSquashFurSum.Count; i++)
        {
            GameObject Fare= AxeSquashFurSum[i];
            if (AxeSquashRunoff > i)
            {
                Fare.SetActive(true);
                if (Fare.GetComponent<CanvasGroup>().alpha != 1)
                {
                    //AgreeOwn.EraChlorine().PlayEffect(AgreeFirm.UIMusic.Sound_RewardBoxSch);
                    Fare.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "1", false);
                }
                Fare.GetComponent<CanvasGroup>().DOFade(1, 0.3f);
            }
            else
            {
                Fare.SetActive(false);
                Fare.GetComponent<CanvasGroup>().alpha = 0;
            }
            if (AxeSquashRunoff == 5)
            {

                //BoxRewardSlider = 0;
                StartCoroutine(TunePylonDelta(() =>
                {
                    Fare.SetActive(false);
                    Fare.GetComponent<CanvasGroup>().alpha = 0;
                    //PBLight.GetComponent<CanvasGroup>().DOFade(0, 0.1f);
                }));
            }
        }
        if (AxeSquashRunoff == 5)
            yield return new WaitForSeconds(5f);
        else
            yield return new WaitForSeconds(0.5f);
        finish?.Invoke();
        
    }

    public IEnumerator TunePylonDelta(System.Action finish) 
    {
        yield return new WaitForSeconds(0.2f);
        //PBLight.GetComponent<CanvasGroup>().DOFade(1, 0.2f);
        yield return new WaitForSeconds(1f);
        UIWorship.EraChlorine().TuneUIAware("PylonDelta");
        finish();
    }

    public IEnumerator VigilancePin() 
    {
        yield return new WaitForSeconds(0.3f);
        FX_Vigilance.transform.position = VigilanceHailAthensRail.transform.parent.position;
        FX_Vigilance.SetActive(true);
        FX_Vigilance.transform.DOMove(VigilanceAlterRail.transform.position, 0.1f).OnComplete(()=> 
        {
            SquashVigilanceFare.SetActive(true);
            SquashVigilanceFare.transform.DOScale(1, 0.1f).SetEase(Ease.OutBack).OnComplete((() =>
            {
                if (type == 0)
                    TraceEnrichTownWiseWorship.EraChlorine().EelBriny(Value, CrowbarSquashTwine.transform);
                else
                    TraceEnrichTownWiseWorship.EraChlorine().EelRide(Value, CrowbarSquashTwine.transform);
            }));
            FX_Vigilance.SetActive(false);
        });
    }
    
    public IEnumerator SureRisk(float time, Action finish) 
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
    }
    public void CardBoxFossilize(Transform startTransform, double num)
    {
        EelFossilize(startTransform, DeemTF, DeemTF.gameObject, DeemRail, TraceEnrichTownWiseWorship.EraChlorine().RubRide(), num);
    }

    public void UntilBoxFossilize(Transform startTransform, double num)
    {
        EelFossilize(startTransform, FareTF, FareTF.gameObject, FareRail, TraceEnrichTownWiseWorship.EraChlorine().RubBriny(), num);
    }

    private void EelFossilize(Transform startTransform, Transform endTransform, GameObject icon, Text text, double textValue, double num)
    {
        if (startTransform != null)
        {
            var count = TraceEnrichAnewWorship.instance.EraBoxCajun(double.Parse(text.text), textValue, endTransform == FareTF.transform);
            FossilizeInsatiable.TraceSowRideWorm(icon, count, startTransform.position, endTransform.position, () =>
            {
                FossilizeInsatiable.OutwitBright(double.Parse(text.text), textValue, 0f, text, () =>
                {
                    text.text = BrightFlaw.PotatoIDGin(textValue);
                });
            }, () => { });
        }
        else
        {
            FossilizeInsatiable.OutwitBright(double.Parse(text.text), textValue, 0f, text, () => {
                text.text = BrightFlaw.PotatoIDGin(textValue);
            });
        }
    }

    private void AbsenceStrictUI()
    {
        for (int i = 0; i < StrictStop.Count; i++)
        {
            StrictStop[i].transform.localScale = new Vector3(1, 1, 1);
            if (TraceEnrichParisWorship.Instance.Strict.ContainsKey(i + 2))
            {
                StrictStop[i].gameObject.SetActive(true);
                if (TraceEnrichParisWorship.Instance.Strict[i + 2] == "0")
                {
                    StrictStop[i].transform.GetChild(0).gameObject.SetActive(false);
                    StrictStop[i].transform.GetChild(1).gameObject.SetActive(true);
                }
                else
                {
                    StrictStop[i].transform.GetChild(0).gameObject.SetActive(true);
                    StrictStop[i].transform.GetChild(1).gameObject.SetActive(false);
                    StrictStop[i].transform.GetChild(0).GetComponent<Text>().text = TraceEnrichParisWorship.Instance.Strict[i + 2];
                }
            }
            else
            {
                StrictStop[i].gameObject.SetActive(false);
            }
        }
    }
    //关卡结束动画
    public void ParisCannonFossilize(Action finish)
    {
        Vector3 StartTitlePos = TunePity[0].transform.GetChild(0).position;
        PBLiter.SetActive(false);
        PBLiter.transform.localScale = new Vector3(0, 0, 0);
        PBLiter.transform.parent.GetChild(0).transform.localScale = new Vector3(1, 1, 1);
        for (int i = 0; i < TunePity.Count; i++)
        {
            if (i == 0)
            {
                TunePity[i].transform.GetChild(0).gameObject.SetActive(true);
                TunePity[i].transform.localScale = new Vector3(0, 0, 0);
                TunePity[i].transform.DOScale(0.7f, 0.3f).SetEase(Ease.OutBack);
            }
            else
            {
                TunePity[i].transform.GetChild(0).gameObject.SetActive(false);
                TunePity[i].transform.localScale = new Vector3(0, 0, 0);
            }
        }
        TunePity[0].transform.GetChild(0).position = new Vector3(0, 0, 0);
        TunePity[0].transform.GetChild(0).DOMove(StartTitlePos, 0.3f).OnComplete(() =>
        {
            TunePity[1].transform.GetChild(0).gameObject.SetActive(true);
            TunePity[1].transform.DOScale(0.7f, 0.3f).OnComplete(() =>
            {
                finish();
                PBLiter.transform.parent.GetChild(0).transform.DOScale(0, 0.3f).OnComplete(() =>
                {
                    PBLiter.SetActive(true);
                    PBLiter.transform.DOScale(1, 0.3f);
                });
            });
        });
    }
}
