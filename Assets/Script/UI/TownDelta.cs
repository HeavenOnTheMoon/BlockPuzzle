using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using DG.Tweening;
using Spine;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class TownDelta : TineUIAware
{
    public static TownDelta Instance;
[UnityEngine.Serialization.FormerlySerializedAs("GoldButton")]
    public Button RideShould;
[UnityEngine.Serialization.FormerlySerializedAs("TokenBtn")]    public Button BrinySow;
[UnityEngine.Serialization.FormerlySerializedAs("SettingBtn")]    
    public Button LifewaySow;
[UnityEngine.Serialization.FormerlySerializedAs("BrainBtn")]    public Button HyperSow;
[UnityEngine.Serialization.FormerlySerializedAs("TargetList")]    
    public List<GameObject> StrictPity;
[UnityEngine.Serialization.FormerlySerializedAs("CoinText")]    public TextMeshProUGUI DeemRail;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public TextMeshProUGUI FareRail;
[UnityEngine.Serialization.FormerlySerializedAs("CashTF")]    public Transform FareTF;
[UnityEngine.Serialization.FormerlySerializedAs("CoinTF")]    public Transform DeemTF;
[UnityEngine.Serialization.FormerlySerializedAs("LevelOverSpine")]
    public GameObject ParisRingOvert;
[UnityEngine.Serialization.FormerlySerializedAs("Correct")]
    public GameObject Correct;
[UnityEngine.Serialization.FormerlySerializedAs("LevelStart")]
    public GameObject ParisSpank;
[UnityEngine.Serialization.FormerlySerializedAs("BlockGroupObjs")]
    public GameObject TraceLiterStop;
[UnityEngine.Serialization.FormerlySerializedAs("ComboItem")]
    public GameObject TenonPack;
[UnityEngine.Serialization.FormerlySerializedAs("SourceItem")]    public GameObject AthensPack;
[UnityEngine.Serialization.FormerlySerializedAs("CheckBoardGroup")]
    public GameObject GypsySaladLiter;
[UnityEngine.Serialization.FormerlySerializedAs("GameBoard")]    public GameObject TownSalad;
[UnityEngine.Serialization.FormerlySerializedAs("MoreClear")]
    public GameObject BikeBlame;
[UnityEngine.Serialization.FormerlySerializedAs("ComboSpine")]    public GameObject TenonOvert;
[UnityEngine.Serialization.FormerlySerializedAs("WheelRightImage")]
    public Image PerchAwardTwine;
[UnityEngine.Serialization.FormerlySerializedAs("WheelReward1")]    public PerchSquashPack PerchSquash1;
[UnityEngine.Serialization.FormerlySerializedAs("WheelReward2")]    public PerchSquashPack PerchSquash2;
[UnityEngine.Serialization.FormerlySerializedAs("BrainImage")]
    public Image HyperTwine;
[UnityEngine.Serialization.FormerlySerializedAs("BrainProgressText")]    public Text HyperHomesickRail;
[UnityEngine.Serialization.FormerlySerializedAs("BlockSP")]
    public List<GameObject> TraceSP;
[UnityEngine.Serialization.FormerlySerializedAs("TargetBarObj")]
    public GameObject StrictLowSum;
[UnityEngine.Serialization.FormerlySerializedAs("SourceBarObj")]    public GameObject AthensLowSum;
[UnityEngine.Serialization.FormerlySerializedAs("CueSourceText")]
    public Text ShyAthensRail;
[UnityEngine.Serialization.FormerlySerializedAs("MaxSourceText")]    public Text RimAthensRail;
[UnityEngine.Serialization.FormerlySerializedAs("MaskObj")]    
    public GameObject FeatSum;
[UnityEngine.Serialization.FormerlySerializedAs("Ancu")]
    public AnimationCurve Beng;
[UnityEngine.Serialization.FormerlySerializedAs("BottomBar")]
    public GameObject RefuteLow;
[UnityEngine.Serialization.FormerlySerializedAs("ClearSpineRect")]
    public List<SkeletonGraphic> BlameOvertMost;
[UnityEngine.Serialization.FormerlySerializedAs("ClearSpineSquare")]    public List<SkeletonGraphic> BlameOvertSilent;
[UnityEngine.Serialization.FormerlySerializedAs("BonusSpine")]
    public SkeletonAnimation BylawOvert;


    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if ((float)Screen.height / Screen.width < 1.8f)
        {
            if (!OliverFlaw.OnSpanAB())
            {
                TraceLiterStop.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1090);
                GypsySaladLiter.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -658);
                TownSalad.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -660);
                TraceLiterStop.transform.localScale = new Vector3(0.86f, 0.86f, 0.86f);
            }
           
            GypsySaladLiter.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            TownSalad.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            
        }
        LifewaySow.onClick.AddListener(() =>
        {
            //UIWorship.EraChlorine().ShowUIForms("QualitativeDelta");
            FailWiseWorship.FatThrive(CBarter.My_LifewayTwig, OliverFlaw.TownBull());
            UIWorship.EraChlorine().TuneUIAware("LifewayDelta");
        });
        HyperSow.onClick.AddListener((() =>
        {
            UIWorship.EraChlorine().TuneUIAware("HyperDelta");
        }));
       
        if (OliverFlaw.OnCycle())
        {
            BrinySow.transform.parent.gameObject.SetActive(false);
        }
        

        RideShould.onClick.AddListener(() => {
            
        });
        
        BrinySow.onClick.AddListener(() =>
        {
            
        });
        
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_Up_Pigment, (messageData) =>
        {
            CardBoxFossilize(messageData.OliveExcursion, messageData.OlivePotato);
        });
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_Up_Director, (messageData) =>
        {
            UntilBoxFossilize(messageData.OliveExcursion, messageData.OlivePotato);
        });
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_Up_DirectorFlannel, (messageData) =>
        {
            UntilBoxFossilizePreside(messageData.OliveExcursion, messageData.Olive2Excursion, messageData.OlivePotato);
        });
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_AbsenceParisStrict, data =>
        {
            AbsenceStrictUI();
        });
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_AbsenceAthens, data =>
        { 
            AbsenceAthensUI();
        });
        
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_PerchUI, data =>
        {
            AbsencePerchUI(data.OliveWit, data.OlivePotato);
        });
        
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_HyperUI, data =>
        {
            AbsenceHyperUI();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public override void Display()
    {
        base.Display();
        
        FailWiseWorship.FatKnow(CBarter.My_SomehowBylaw, false);
        TownDelta.Instance.TraceLiterStop.GetComponent<CanvasGroup>().alpha =1 ;
        TownDelta.Instance.RefuteLow.GetComponent<CanvasGroup>().alpha = 1;
        Correct.gameObject.SetActive(false);

        StartCoroutine(Wild(1f,()=>
        {
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_startgame);
        }));
        
        if (FailWiseWorship.EraWit(CBarter.My_SolidTownFur) == 0)
        {
            
        }
        if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "challenge")
        {
            TripGlassSevere.EraChlorine().RichGlass("1007", (TraceEnrichParisWorship.Instance.EraLawParis() + 1).ToString());
            StrictLowSum.gameObject.SetActive(true);
            AthensLowSum.gameObject.SetActive(false);
            //初始化关卡目标和当前信息
            TraceEnrichParisWorship.Instance.EraLawParisTell();
            TraceEnrichParisWorship.Instance.RakeStrict();
            
        }
        else
        {
            TripGlassSevere.EraChlorine().RichGlass("1020");
            //积分制
            StrictLowSum.gameObject.SetActive(false);
            AthensLowSum.gameObject.SetActive(true);
            //初始化关卡目标和当前信息
            TraceEnrichParisWorship.Instance.EraLawParisTell();
        }
        TraceEnrichAthensWorship.Instance.BlamePlusAthens();
        //刷新棋盘
        TraceEnrichGypsySaladWorship.Instance.AbsenceGypsySalad(GypsySaladLiter);
        FailWiseWorship.FatWit(CBarter.My_GlassDormantWrap, 0);
        TraceEnrichAthensWorship.Instance.BlameTenon();
        
        DeemRail.text = (TraceEnrichTownWiseWorship.EraChlorine().RubRide().ToString("f0"));
        FareRail.text = BrightFlaw.PotatoIDGin(TraceEnrichTownWiseWorship.EraChlorine().RubBriny());

        AbsenceStrictUI();
        AbsenceAthensUI();
        AbsencePerchUI();
        AbsenceHyperUI();
        
        FeatSum.gameObject.SetActive(false);
        if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "challenge")
        {
            ParisSpank.SetActive(true);
            ParisSpank.GetComponent<ParisStrict>().TuneFossilize(StrictPity, () => 
            {
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Targetfly);
                AbsenceStrictUI();
                TraceEnrichTraceWorship.Instance.LowerTrace();
            
                if (TraceEnrichParisWorship.Instance.EraLawParis() + 1 == PryTellOwn.instance.TownWise.RateUs && !OliverFlaw.OnCycle() && 
                    FailWiseWorship.EraWit(CBarter.My_Remind) == 0)
                {
                    UIWorship.EraChlorine().TuneUIAware("ClueBeDelta");
                }
            });
        }
        else
        {
            ParisSpank.SetActive(false);
            StartCoroutine(Wild(1.5f, () =>
            {
                TraceEnrichTraceWorship.Instance.LowerTrace();
            }));
        }


        

    }
    
    public void CardBoxFossilize(Transform startTransform, double num)
    {
        EelFossilize(startTransform, DeemTF, DeemTF.gameObject, DeemRail, TraceEnrichTownWiseWorship.EraChlorine().RubRide(), num);
    }

    public void UntilBoxFossilize(Transform startTransform, double num)
    {
        EelFossilize(startTransform, FareTF, FareTF.gameObject, FareRail, TraceEnrichTownWiseWorship.EraChlorine().RubBriny(), num);
    }
    public void UntilBoxFossilizePreside(Transform startTransform, Transform bottomTransform, double num)
    {
        EelFossilizePreside(startTransform, FareTF, bottomTransform, FareTF.gameObject, FareRail, TraceEnrichTownWiseWorship.EraChlorine().RubBriny(), num);
    }

    private void EelFossilizePreside(Transform startTransform, Transform endTransform, Transform bottomTransform, GameObject icon, TextMeshProUGUI text, double textValue, double num)
    {
        if (startTransform != null)
        {
            var count = TraceEnrichAnewWorship.instance.EraBoxCajun(double.Parse(text.text), textValue, endTransform == FareTF.transform);
            FossilizeInsatiable.TraceSowRideCube(icon, count, startTransform.position, endTransform.position, bottomTransform.position, () =>
            {
                FossilizeInsatiable.OutwitBright(double.Parse(text.text), textValue, 0.1f, text, () =>
                {
                    text.text = BrightFlaw.PotatoIDGin(textValue);
                    if (FailWiseWorship.EraWit(CBarter.My_SolidTownFur) == 0 && !OliverFlaw.OnCycle())
                    {
                        UIWorship.EraChlorine().TuneUIAware("SolidDelta");
                        
                    }
                });
            }, Beng, () => { });
        }
        else
        {
            FossilizeInsatiable.OutwitBright(double.Parse(text.text), textValue, 0.1f, text, () => {
                text.text = BrightFlaw.PotatoIDGin(textValue);
            });
        }
    }

    private void EelFossilize(Transform startTransform, Transform endTransform, GameObject icon, TextMeshProUGUI text, double textValue, double num)
    {
        if (startTransform != null)
        {
            var count = TraceEnrichAnewWorship.instance.EraBoxCajun(double.Parse(text.text), textValue, endTransform == FareTF.transform);

            FossilizeInsatiable.TraceSowRideWorm(icon, count, startTransform.position, endTransform.position, () =>
            {
                FossilizeInsatiable.OutwitBright(double.Parse(text.text), textValue, 0.1f, text, () =>
                {
                    text.text = BrightFlaw.PotatoIDGin(textValue);
                    if (FailWiseWorship.EraWit(CBarter.My_SolidTownFur) == 0 && !OliverFlaw.OnCycle())
                    {
                        UIWorship.EraChlorine().TuneUIAware("SolidDelta");
                        
                    }
                });
            }, () => { });
        }
        else
        {
            FossilizeInsatiable.OutwitBright(double.Parse(text.text), textValue, 0.1f, text, () => {
                text.text = BrightFlaw.PotatoIDGin(textValue);
            });
        }
    }

    private void AbsenceStrictUI()
    {

        for (int i = 0; i < StrictPity.Count; i++)
        {
            StrictPity[i].transform.localScale = new Vector3(1, 1, 1);
            if (TraceEnrichParisWorship.Instance.Strict.ContainsKey(i + 2))
            {
                StrictPity[i].gameObject.SetActive(true);
                if (TraceEnrichParisWorship.Instance.Strict[i + 2] == "0" /*&& !TargetList[i].transform.GetChild(1).gameObject.activeSelf*/)
                {
                    StrictPity[i].transform.GetChild(0).gameObject.SetActive(false);
                    StrictPity[i].transform.GetChild(1).gameObject.SetActive(true);
                }
                else
                {
                    StrictPity[i].transform.GetChild(0).gameObject.SetActive(true);
                    StrictPity[i].transform.GetChild(1).gameObject.SetActive(false);
                    if (StrictPity[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text != TraceEnrichParisWorship.Instance.Strict[i + 2])
                    {
                        StrictPity[i].transform.DOScale(1.2f, 0.06f).SetEase(Ease.OutSine);
                        StrictPity[i].transform.DOScale(1f, 0.2f).SetDelay(0.1f).SetEase(Ease.OutSine);
                    }
                    StrictPity[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = TraceEnrichParisWorship.Instance.Strict[i + 2];
                }
            }
            else
            {
                StrictPity[i].gameObject.SetActive(false);
            }
        }
    }

    private void AbsencePerchUI(int oldWheelReward = -1, double rewardValue = 0)
    {
        if (OliverFlaw.OnCycle())
        {
            PerchAwardTwine.transform.parent.gameObject.SetActive(false);
            ReplicaHomesickLow(PerchAwardTwine, 0.5f, 0.5f);
        }
        else
        {
            int totalCount = PryTellOwn.instance.TownWise.WheelReward.ShowCount;
            int currentCount = TraceEnrichAnewWorship.instance.EraPerchFur();
            float value = (float)currentCount / (totalCount * 3);
            //if (value < 0.5f)
            //{
            //    value = value / 1.1785f;
            //}
            ReplicaHomesickLow(PerchAwardTwine, 0.5f, value);

            // 处理奖励图标
            int newWheelReward = FailWiseWorship.EraWit(CBarter.My_PerchSquash);
            bool hasReward = newWheelReward > oldWheelReward;   // 是否需要播放奖励动画
            string MakeupFirm= PryTellOwn.instance.TownWise.WheelReward.Reward[0].type;
            if (!hasReward || oldWheelReward == -1)
            {
                // 不需要发奖励，直接显示奖品图标
                PerchSquash1.FatMidst(newWheelReward >= 1, MakeupFirm, rewardValue);
                PerchSquash2.FatMidst(newWheelReward >= 2, MakeupFirm, rewardValue);
            }
            else
            {
                // 需要发奖励，打开奖励弹窗
                PerchSquashPack Fare= newWheelReward == 1 ? PerchSquash1 : PerchSquash2;
                Fare.FatMidst(true, MakeupFirm, rewardValue);
                FailWiseWorship.FatThrive(CBarter.My_SquashFirm, PryTellOwn.instance.TownWise.WheelReward.Reward[0].type);
                FailWiseWorship.FatThrive(CBarter.My_SquashStick, rewardValue.ToString());
                StartCoroutine(Wild(1.2f, () =>
                {
                    UIWorship.EraChlorine().TuneUIAware("SquashDelta");
                    //MaskObj.SetActive(false);
                }));
                
            }
        }
        
    }

    private void AbsenceHyperUI()
    {
        var Wish= TraceEnrichAthensWorship.Instance.EraPlusEarnerTell(19);
        float Beg= (float)Wish.Athens / PryTellOwn.instance.TownWise.SourceRewards.dailyMaxSource;
        //WheelLeftImage
        ReplicaHomesickLow(HyperTwine, 0.5f, Beg);
        HyperHomesickRail.text = (int)(Beg * 100) + "%";
    }

    private void ReplicaHomesickLow(Image image, float time, float endValue)
    {
        if (endValue == 0)
        {
            image.fillAmount = 0;
        }
        else
        {
            image.DOFillAmount(endValue, time).SetEase(Ease.Linear);
        }
    }
    
    public void AbsenceAthensUI()
    {
        var startNum = FailWiseWorship.EraWit(CBarter.My_LawAthensCajun);
        if (FailWiseWorship.EraWit(CBarter.My_LawAthensCajun) == FailWiseWorship.EraWit(CBarter.My_RimAthensCajun))
        {
            DOTween.To(() => float.Parse(ShyAthensRail.text), x => ShyAthensRail.text = x.ToString("f0"), startNum, 0.5f).OnComplete(() => 
            {
                
            });
            DOTween.To(() => float.Parse(RimAthensRail.text), x => RimAthensRail.text = x.ToString("f0"), startNum, 0.5f).OnComplete(() => 
            {
                
            });
            //CueSourceText.text = FailWiseWorship.GetFloat(CBarter.sv_CurSourceCount).ToString("f0");
            //MaxSourceText.text = CueSourceText.text;
        }
        else
        {
            DOTween.To(() => float.Parse(ShyAthensRail.text), x => ShyAthensRail.text = x.ToString("f0"), startNum, 0.5f).OnComplete(() => 
            {
                
            });
            //CueSourceText.text = FailWiseWorship.GetFloat(CBarter.sv_CurSourceCount).ToString("f0");
            RimAthensRail.text = FailWiseWorship.EraWit(CBarter.My_RimAthensCajun).ToString("f0");
        }
    }

    /// <summary>
    /// 胜利Spine动画
    /// </summary>
    /// <param name="LifeOrDie"></param>
    /// <param name="finish"></param>
    public void ParisCrowbar(bool LifeOrDie , System.Action finish) 
    {
        ParisRingOvert.SetActive(true);
        if (LifeOrDie)
        {
            TripGlassSevere.EraChlorine().RichGlass("1008", (TraceEnrichParisWorship.Instance.EraLawParis() + 1).ToString());
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Welldone);
            ParisRingOvert.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "Victory", false);
        }
        else 
        {
            TripGlassSevere.EraChlorine().RichGlass("1009", (TraceEnrichParisWorship.Instance.EraLawParis() + 1).ToString());
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Fail);
            ParisRingOvert.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "Fail", false);
        }
        StartCoroutine(Wild(2.5f,()=>
        {
            ParisRingOvert.SetActive(false);
            finish();
        }));
    }

    public IEnumerator Wild(float time, System.Action finish) 
    {
        yield return new WaitForSeconds(time);
        finish();
    }


    public void TenonTunePin(int A, Vector3 Start, bool isShowConbo)
    {
        GameObject Comboitem = Instantiate(TenonPack, transform);
        Vector3 pos = new Vector3();
        if (Start.x > 0.7f)
        {
            Start = new Vector3(0.7f, Start.y, Start.z);
        }
        if (Start.x < -0.7f)
        {
            Start = new Vector3(-0.7f, Start.y, Start.z);
        }
        if (Start.y > 0.8f)
        {
            Start = new Vector3(Start.x, 0.8f, Start.z);
        }
        if (Start.y < -0.8f)
        {
            Start = new Vector3(Start.x, -0.8f, Start.z);
        }

        Comboitem.transform.position = Start;
        pos = new Vector3(Start.x, Start.y - 80, 0);

        if (isShowConbo)
        {
            Comboitem.GetComponent<TraceEnrichTenonRender>().Rake(A);
            //Comboitem.transform.position = ComboTF;
            Comboitem.transform.localScale = new Vector3(0, 0, 0);
            Comboitem.GetComponent<CanvasGroup>().alpha = 1;
            Comboitem.SetActive(true);
            Comboitem.transform.DOScale(1.2f, 0.3f).SetEase(Ease.OutBack).OnComplete(() =>
            {
                Comboitem.GetComponent<CanvasGroup>().DOFade(0, 0.5f).SetDelay(0.3f).OnComplete(() =>
                {
                    Destroy(Comboitem);
                });
            });
        }
        TuneAthensPack(pos, null, false);
    }

    public void TuneBlameOvert(int type, BlockColor color, Vector3 position)
    {
        var spinePrefab = BlameOvertMost[0];
        if (type == 1 || type == 2)
        {
            spinePrefab = BlameOvertMost[(int)color];
        }
        else if (type == 3)
        {
            spinePrefab = BlameOvertSilent[(int)color];
        }
        var Stock= Instantiate(spinePrefab, spinePrefab.transform.parent);
        Stock.GetComponent<RectTransform>().position = position;
        Stock.GetComponent<RectTransform>().localRotation = type == 2 ? Quaternion.AngleAxis(90, Vector3.forward) : Quaternion.AngleAxis(0, Vector3.forward);
        Stock.gameObject.SetActive(true);
        Stock.AnimationState.Complete += (TrackEntry trackEntry) => { Destroy(Stock.gameObject); };
        Stock.AnimationState.SetAnimation(0, "animation", false);
    }

    public void TuneAthensPack(Vector2 startPos, Transform startTranPos, bool isTran)
    {
        
        //if (sourceValue > 0)
        {
            GameObject _sourceItem = Instantiate(AthensPack, transform);
            if (isTran)
            {
                var position = startTranPos.position;
                _sourceItem.transform.position = position;
            }
            else
            {
                _sourceItem.GetComponent<RectTransform>().anchoredPosition = startPos;
            }
            _sourceItem.transform.GetChild(0).GetComponent<Text>().text = TraceEnrichAthensWorship.Instance.PlusAthens.ToString();
            _sourceItem.transform.localScale = new Vector3(0, 0, 0);
            _sourceItem.GetComponent<CanvasGroup>().alpha = 1;
            _sourceItem.SetActive(true);
            _sourceItem.transform.DOScale(0.7f, 0.3f).SetEase(Ease.OutBack).OnComplete(()=> 
            {
                _sourceItem.GetComponent<CanvasGroup>().DOFade(0, 0.5f).SetDelay(0.3f).OnComplete(() =>
                {
                    Destroy(_sourceItem);
                });
            });
        }
    }
}

