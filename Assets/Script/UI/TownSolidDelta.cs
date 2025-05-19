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

public class TownSolidDelta : TineUIAware
{
    public static TownSolidDelta Instance;
[UnityEngine.Serialization.FormerlySerializedAs("BlockGroupObjs")]    
    public GameObject TraceLiterStop;
[UnityEngine.Serialization.FormerlySerializedAs("ComboItem")]
    public GameObject TenonPack;
[UnityEngine.Serialization.FormerlySerializedAs("SourceItem")]    public GameObject AthensPack;
[UnityEngine.Serialization.FormerlySerializedAs("CheckBoardGroup")]
    public GameObject GypsySaladLiter;
[UnityEngine.Serialization.FormerlySerializedAs("GameBoard")]    public GameObject TownSalad;
[UnityEngine.Serialization.FormerlySerializedAs("BlockSP")]    public List<GameObject> TraceSP;
[UnityEngine.Serialization.FormerlySerializedAs("MoreClear")]    public GameObject BikeBlame;
[UnityEngine.Serialization.FormerlySerializedAs("ComboSpine")]    public GameObject TenonOvert;
[UnityEngine.Serialization.FormerlySerializedAs("TargetBarObj")]    public GameObject StrictLowSum;
[UnityEngine.Serialization.FormerlySerializedAs("SourceBarObj")]    public GameObject AthensLowSum;
[UnityEngine.Serialization.FormerlySerializedAs("CueSourceText")]
    public TextMeshProUGUI ShyAthensRail;
[UnityEngine.Serialization.FormerlySerializedAs("MaxSourceText")]    public Text RimAthensRail;
[UnityEngine.Serialization.FormerlySerializedAs("GuideSpine")]    public SkeletonGraphic SolidOvert;
[UnityEngine.Serialization.FormerlySerializedAs("MaskObj")]    public GameObject FeatSum;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeSceneMask")]    public GameObject OutwitFlierFeat;
[UnityEngine.Serialization.FormerlySerializedAs("ClearSpineRect")]
    public List<SkeletonGraphic> BlameOvertMost;
[UnityEngine.Serialization.FormerlySerializedAs("ClearSpineSquare")]    public List<SkeletonGraphic> BlameOvertSilent;
[UnityEngine.Serialization.FormerlySerializedAs("CashTF")]
    public Transform FareTF;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public TextMeshProUGUI FareRail;


    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if ((float)Screen.height / Screen.width < 1.8f)
        {
            TraceLiterStop.transform.localScale = new Vector3(0.86f, 0.86f, 0.86f);
            TraceLiterStop.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -1090);
            GypsySaladLiter.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            GypsySaladLiter.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -658);
            TownSalad.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            TownSalad.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -660);
            SolidOvert.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            SolidOvert.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -900);
        }
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_AbsenceAthens, data =>
        { 
            AbsenceAthensUI();
        });
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_OutwitSolidTownBulb, data =>
        {
            StartCoroutine(Wild(1.5f, () =>
            {
                OutwitSolidTownBulb();
            }));
        });
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_Up_DirectorFlannel, (messageData) =>
        {
            UntilBoxFossilize(messageData.OliveExcursion, messageData.OlivePotato);
        });
    }

    float Park= 0;
[UnityEngine.Serialization.FormerlySerializedAs("isStart")]    public bool WeSpank= false;
    // Update is called once per frame
    void Update()
    {
        if(WeSpank)
            Park += Time.deltaTime;
        if (Park > 1.0f && !SolidOvert.gameObject.activeSelf)
        {
            Park = 0;
            SkeletonGraphic skeleton = SolidOvert.gameObject.GetComponent<SkeletonGraphic>();
            skeleton.AnimationState.SetEmptyAnimation(0, 0);
            skeleton.AnimationState.AddAnimation(0, (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) + 1).ToString(), true, 0);
            skeleton.Update(0); 
            SolidOvert.gameObject.SetActive(true); 
        }
    }
    
    public override void Display()
    {
        base.Display();
        FailWiseWorship.FatThrive(CBarter.My_LawTownDrum, "Guide");
        
        StartCoroutine(Wild(1f,()=>
        {
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_startgame);
        }));
        TripGlassSevere.EraChlorine().RichGlass("1007", (TraceEnrichParisWorship.Instance.EraLawParis() + 1).ToString());
        StrictLowSum.gameObject.SetActive(false);
        AthensLowSum.gameObject.SetActive(true);
        TraceEnrichParisWorship.Instance.EraLawParisTell();
        
        TraceEnrichAthensWorship.Instance.BlamePlusAthens();
        //刷新棋盘
        TraceEnrichGypsySaladWorship.Instance.AbsenceGypsySalad(GypsySaladLiter);
        FailWiseWorship.FatWit(CBarter.My_GlassDormantWrap, 0);
        TraceEnrichAthensWorship.Instance.BlameTenon();


        AbsenceAthensUI();
        
        FeatSum.gameObject.SetActive(false);
        
        StartCoroutine(Wild(0.5f, () =>
        {
            TraceEnrichTraceWorship.Instance.LowerTrace();
            WeTuneRate(true);
        }));

        if (OliverFlaw.OnCycle())
        {
            AthensLowSum.SetActive(true);
            FareRail.transform.parent.gameObject.SetActive(false);
        }
        else
        {
            AthensLowSum.SetActive(false);
            FareRail.transform.parent.gameObject.SetActive(true);
            FareRail.text = BrightFlaw.PotatoIDGin(TraceEnrichTownWiseWorship.EraChlorine().RubBriny());
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

    public IEnumerator Wild(float time, System.Action finish) 
    {
        yield return new WaitForSeconds(time);
        finish();
    }


    public void TenonTunePin(int A,int Pos, bool isShowConbo) 
    {
        GameObject Comboitem = Instantiate(TenonPack, transform);
        Vector2 pos = new Vector2();
        switch (Pos)
        {
            case 1: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(-160,-150);
                pos = new Vector2(-160,-220);
                break;
            case 2: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(-160, 85); 
                pos = new Vector2(-160,5);
                break;
            case 3: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(-160, 300); 
                pos = new Vector2(-160,230);
                break;
            case 4: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -150);
                pos = new Vector2(0,-220);
                break;
            case 5: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 85); 
                pos = new Vector2(0,5);
                break;
            case 6: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 300);
                pos = new Vector2(0,230);
                break;
            case 7: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(160, -150); 
                pos = new Vector2(160,-220);
                break;
            case 8: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(160, 85); 
                pos = new Vector2(160,5);
                break;
            case 9: Comboitem.GetComponent<RectTransform>().anchoredPosition = new Vector2(160, 300); 
                pos = new Vector2(160,230);
                break;
        }
        if (isShowConbo)
        {
            Comboitem.GetComponent<TraceEnrichTenonRender>().Rake(A);
            //Comboitem.transform.position = ComboTF;
            Comboitem.transform.localScale = new Vector3(0, 0, 0);
            Comboitem.GetComponent<CanvasGroup>().alpha = 1;
            Comboitem.SetActive(true);
            Comboitem.transform.DOScale(0.7f, 0.3f).SetEase(Ease.OutBack).OnComplete(()=> 
            {
                Comboitem.GetComponent<CanvasGroup>().DOFade(0, 0.5f).SetDelay(0.3f).OnComplete(() =>
                {
                    Destroy(Comboitem);
                });
            });
        }
        TuneAthensPack(pos, null, false);
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
            _sourceItem.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = TraceEnrichAthensWorship.Instance.PlusAthens.ToString();
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

    private void OutwitOnFeldsparSolid()
    {
        
    }

    private void OutwitSolidTownBulb()
    {

        /*FailWiseWorship.SetInt(CBarter.sv_GuideGameRule, 99);
        ChangeSceneMask = UIWorship.GetInstance().MainCanvas.transform.Find("Top/OutwitFlier").gameObject;
        FailWiseWorship.SetString(CBarter.sv_CurGameMode, PryTellOwn.instance.GameData.ShowAdventure ? "challenge" : "Classic");
        ChangeSceneMask.SetActive(true);
        ChangeSceneMask.GetComponent<OutwitFlier>().ChangeSceneAni(() =>
        {
            TripGlassSevere.GetInstance().RichGlass("1024");
            UIWorship.GetInstance().ShowUIForms("TownDelta");
        }, () =>
        {
            CloseUIForm(GetType().Name);
        });
        //RefreshUI();*/

        switch (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb))
        {
            case 0:
                if (TraceEnrichGypsySaladWorship.Instance.BlameTraceLiterCajun == 2)
                {
                    FailWiseWorship.FatWit(CBarter.My_SolidTownBulb, 1);
                    AbsenceUI();
                }
                else
                    AbsenceUI();
                break;
            case 1:
                if (TraceEnrichGypsySaladWorship.Instance.BlameTraceLiterCajun == 1)
                {
                    FailWiseWorship.FatWit(CBarter.My_SolidTownBulb, 2);
                    AbsenceUI();
                }
                else
                    AbsenceUI();
                break;
            case 2:
                if (TraceEnrichGypsySaladWorship.Instance.BlameTraceLiterCajun == 4)
                {
                    FailWiseWorship.FatWit(CBarter.My_SolidTownBulb, 99);
                    TripGlassSevere.EraChlorine().RichGlass("1024");
                    UIWorship.EraChlorine().TuneUIAware(OliverFlaw.TownBull());
                    WheelUIPick(GetType().Name);
                    OutwitFlierFeat = UIWorship.EraChlorine().AnewGraham.transform.Find("Top/ChangeScene").gameObject;
                    FailWiseWorship.FatThrive(CBarter.My_LawTownDrum, PryTellOwn.instance.TownWise.ShowAdventure ? "challenge" : "Classic");
                   /* ChangeSceneMask.SetActive(true);
                    ChangeSceneMask.GetComponent<OutwitFlier>().ChangeSceneAni(() =>
                    {
                        TripGlassSevere.GetInstance().RichGlass("1024");
                        UIWorship.GetInstance().ShowUIForms("TownDelta");
                    }, () =>
                    {
                        CloseUIForm(GetType().Name);
                    });*/
                    //RefreshUI();
                }
                else
                    AbsenceUI();
                break;
        }
    }

    private void AbsenceUI()
    {
        TraceEnrichTraceWorship.Instance.BlameJetTrace();
        TraceEnrichParisWorship.Instance.EraLawParisTell();
        TraceEnrichAthensWorship.Instance.BlamePlusAthens();
        TraceEnrichGypsySaladWorship.Instance.AbsenceGypsySalad(GypsySaladLiter);
        FailWiseWorship.FatWit(CBarter.My_GlassDormantWrap, 0);
        TraceEnrichAthensWorship.Instance.BlameTenon();

        AbsenceAthensUI();
        StartCoroutine(Wild(0.5f, () =>
        {
            TraceEnrichTraceWorship.Instance.LowerTrace();
            WeTuneRate(true);
        }));
    }

    public void WeTuneRate(bool isShow)
    {
        if (isShow)
            WeSpank = true;
        else
        {
            Park = 0;
            WeSpank = false;
            SolidOvert.gameObject.SetActive(false);
        }
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

    public void UntilBoxFossilize(Transform startTransform, double num)
    {
        EelFossilize(startTransform, FareTF, FareTF.gameObject, FareRail, TraceEnrichTownWiseWorship.EraChlorine().RubBriny(), num);
    }

    private void EelFossilize(Transform startTransform, Transform endTransform, GameObject icon, TextMeshProUGUI text, double textValue, double num)
    {
        if (startTransform != null)
        {
            var count = TraceEnrichAnewWorship.instance.EraBoxCajun(double.Parse(text.text), textValue, endTransform == FareTF.transform);

            FossilizeInsatiable.TraceSowRideWorm(icon, 1, startTransform.position, endTransform.position, () =>
            {
                FossilizeInsatiable.OutwitBright(double.Parse(text.text), textValue, 0.1f, text, () =>
                {
                    text.text = BrightFlaw.PotatoIDGin(textValue);
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

}

