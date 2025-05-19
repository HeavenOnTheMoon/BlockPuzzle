using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using UnityEditor;
using Spine.Unity;
using TMPro;
using System;

public class PylonDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("SlotBlockList")]    public List<GameObject> PlayTracePity;
[UnityEngine.Serialization.FormerlySerializedAs("BlockList_AD")]    public GameObject TracePity_AD;
[UnityEngine.Serialization.FormerlySerializedAs("BlockList")]    public GameObject TracePity;
[UnityEngine.Serialization.FormerlySerializedAs("TimeScale")]    public float SureQuina= 0;
[UnityEngine.Serialization.FormerlySerializedAs("DoubleBtn")]    public Button PotatoSow;
[UnityEngine.Serialization.FormerlySerializedAs("ReceiveBtn")]    public Button AriditySow;
[UnityEngine.Serialization.FormerlySerializedAs("Loops")]    public bool Tribe;
[UnityEngine.Serialization.FormerlySerializedAs("BoxSpine")]
    public GameObject AxeOvert;
[UnityEngine.Serialization.FormerlySerializedAs("RewardBar")]    public GameObject SquashLow;
[UnityEngine.Serialization.FormerlySerializedAs("showList")]    public List<GameObject> FlaxPity;
[UnityEngine.Serialization.FormerlySerializedAs("RewardText")]
    public Text SquashRail;
[UnityEngine.Serialization.FormerlySerializedAs("SlotObjs")]
    public List<GameObject> PlayStop;
[UnityEngine.Serialization.FormerlySerializedAs("EndRewardText")]    public Text CatSquashRail;
[UnityEngine.Serialization.FormerlySerializedAs("CoinText")]
    public TextMeshProUGUI DeemRail;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public TextMeshProUGUI FareRail;
[UnityEngine.Serialization.FormerlySerializedAs("CoinTF")]    public Transform DeemTF;
[UnityEngine.Serialization.FormerlySerializedAs("CashTF")]    public Transform FareTF;

    //public GameObject BlockItem;
    // Start is called before the first frame update
    void Start()
    {
        PotatoSow.onClick.AddListener(() =>
        {
            PotatoSow.enabled = false;
            AriditySow.enabled = false;

            ADManager.Instance.playRewardVideo((success) =>
            {
                if (success)
                {
                    //广告
                    AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_doublereward);
                    TripGlassSevere.EraChlorine().RichGlass("1006", TraceEnrichAthensWorship.Instance.EarnerSquashID.ToString(), "1");
                    PlayLazily();
                    SureQuina = 0.5f;
                    ADPlay(() =>
                    {
                        PerSnow();

                    });
                }
                else
                {
                    PotatoSow.enabled = true;
                    AriditySow.enabled = true;
                }
            }, "3");
           
            
            
        });

        AriditySow.onClick.AddListener(() => 
        {
            PotatoSow.enabled = false;
            AriditySow.enabled = false;
            PlayLazily();
            //加金币
            if (Wish.type == "cash")
                TraceEnrichTownWiseWorship.EraChlorine().EelBriny(value);
            else
                TraceEnrichTownWiseWorship.EraChlorine().EelRide(value);

            TripGlassSevere.EraChlorine().RichGlass("1006", TraceEnrichAthensWorship.Instance.EarnerSquashID.ToString(), "0");
            StartCoroutine(SureRisk(1.5f, () => {
                WheelUIPick(GetType().Name);
                ADManager.Instance.NoThanksAddCount();
                WheelUIPick("CannonDelta");
                if (TraceEnrichTributeWorship.instance.EraFeldsparTributeBadly())
                    UIWorship.EraChlorine().TuneUIAware("VaporDelta");
                else
                    UIWorship.EraChlorine().TuneUIAware(OliverFlaw.TownBull());
                /*GameObject ChangeSceneMask = UIWorship.GetInstance().MainCanvas.transform.Find("Top/OutwitFlier").gameObject;
                ChangeSceneMask.SetActive(true);
                ChangeSceneMask.GetComponent<OutwitFlier>().ChangeSceneAni(() =>
                {
                    CloseUIForm("CannonDelta");
                    if (TraceEnrichTributeWorship.instance.GetCompleteChapterStage())
                        UIWorship.GetInstance().ShowUIForms("VaporDelta");
                    else
                        UIWorship.GetInstance().ShowUIForms("TownDelta");
                }, () =>
                {

                });*/
            }));
        });


        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_Up_Pigment, (messageData) =>
        {
            CardBoxFossilize(messageData.OliveExcursion, messageData.OlivePotato);
        });
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_Up_Director, (messageData) =>
        {
            UntilBoxFossilize(messageData.OliveExcursion, messageData.OlivePotato);
        });
    }

    private void BoxSquash()
    {
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_countup);  
        if (Wish.type == "cash")
        {
                      
            DOTween.To(() => value, x => SquashRail.text = x.ToString("f2"), value * Crossbreed, 0.5f).OnComplete(() => 
            {
                SquashRail.text = (value * Crossbreed).ToString("f2");
                SquashRail.transform.DOScale(1f, 0.3f).SetDelay(1).OnComplete(()=>
                {
                    TraceEnrichTownWiseWorship.EraChlorine().EelBriny(value * Crossbreed);
                    RelaxPotatoSquash();
                });
                            
            });
        }
        else
        {
            DOTween.To(() => value, x => SquashRail.text = x.ToString("f0"), value * Crossbreed, 0.5f).OnComplete(() => 
            {
                SquashRail.text = (value * Crossbreed).ToString("f0");
                SquashRail.transform.DOScale(1f, 0.3f).SetDelay(1).OnComplete(()=>
                {
                    TraceEnrichTownWiseWorship.EraChlorine().EelRide(value * Crossbreed);
                    RelaxPotatoSquash();
                });
                            
            });
        }
    }

    private void RelaxPotatoSquash()
    {
        StartCoroutine(SureRisk(1.5f, () => {
            WheelUIPick(GetType().Name);
            WheelUIPick("CannonDelta");
            if (TraceEnrichTributeWorship.instance.EraFeldsparTributeBadly())
                UIWorship.EraChlorine().TuneUIAware("VaporDelta");
            else
                UIWorship.EraChlorine().TuneUIAware(OliverFlaw.TownBull());
            /*GameObject ChangeSceneMask = UIWorship.GetInstance().MainCanvas.transform.Find("Top/OutwitFlier").gameObject;
            ChangeSceneMask.SetActive(true);
            ChangeSceneMask.GetComponent<OutwitFlier>().ChangeSceneAni(() =>
            {
                CloseUIForm("CannonDelta");
                if (TraceEnrichTributeWorship.instance.GetCompleteChapterStage())
                    UIWorship.GetInstance().ShowUIForms("VaporDelta");
                else
                    UIWorship.GetInstance().ShowUIForms("TownDelta");
            }, () =>
            {

            });*/
        }));
    }

    double value;
    public override void Display()
    {
        base.Display();
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Openboard);
        PotatoSow.enabled = true;
        AriditySow.enabled = true;
        //页面初始化
        Vine();
        AbsencePlayUI();
        //展示动画
        TunePin();
        //宝箱打开动画
        StartCoroutine(AbutAxe());
        //slot转动动画
        PlayPin();
        PlayPin_1();
        TracePity_AD.SetActive(false);

        /*CoinText.text = (TraceEnrichTownWiseWorship.GetInstance().getGold().ToString("f0"));
        CashText.text = BrightFlaw.DoubleToStr(TraceEnrichTownWiseWorship.GetInstance().getToken());*/

    }
    RewardItem Wish;
    /// <summary>
    /// 初始化
    /// </summary>
    public void Vine() 
    {
        SureQuina = 10f;
        PlayTracePity[0].transform.GetChild(3).localScale = new Vector3(1, 1, 1);
        PlayTracePity[0].transform.localPosition = new Vector3(465, 0, 0);
        PlayTracePity[1].transform.localPosition = new Vector3(1395, 0, 0);
        Tribe = true;
        TracePity.SetActive(true);
        SquashLow.SetActive(false);
        AxeOvert.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "idle1", false);
        Wish = TraceEnrichAnewWorship.instance.EraSquashFirm(PryTellOwn.instance.TownWise.BoxInfo.BoxReward);
        if (Wish.type == "cash")
        {
            value = BlockPuzzleGameUtil.GetCashMulti() * double.Parse(Wish.multiple);
            var parent = SquashRail.transform.parent;
            parent.GetChild(0).gameObject.SetActive(true); 
            parent.GetChild(1).gameObject.SetActive(false);
            SquashRail.text = value.ToString("f2");
        }
        else
        {
            value = BlockPuzzleGameUtil.GetGoldMulti() * double.Parse(Wish.multiple);
            var parent = SquashRail.transform.parent;
            parent.GetChild(0).gameObject.SetActive(false); 
            parent.GetChild(1).gameObject.SetActive(true); 
            SquashRail.text = value.ToString("f0");
        }
        
    }


    /// <summary>
    /// 默认状态下的slot轴1
    /// </summary>
    public void PlayPin() 
    {
        var SlotList = DOTween.Sequence();
        
        PlayTracePity[0].transform.DOLocalMoveX(-465, ((PlayTracePity[0].transform.localPosition.x/930)+0.5f)* SureQuina).SetEase(Ease.Linear).OnComplete(()=> 
        {
            PlayTracePity[0].transform.localPosition = new Vector3(1395, 0, 0);
            if (Tribe) 
            {
                PlayPin();
            }
        });
        
    }
    /// <summary>
    /// 默认状态下的slot轴2
    /// </summary>
    public void PlayPin_1()
    {
        var SlotList = DOTween.Sequence();
        PlayTracePity[1].transform.DOLocalMoveX(-465, ((PlayTracePity[1].transform.localPosition.x / 930)+0.5f)* SureQuina).SetEase(Ease.Linear).OnComplete(() =>
        {
            PlayTracePity[1].transform.localPosition = new Vector3(1395, 0, 0);
            if (Tribe)
            {
                PlayPin_1();
            }
            
        });

    }

    /// <summary>
    /// 看视频slot
    /// </summary>
    public void ADPlay(System.Action finish) 
    {
        TracePity.SetActive(false);
        TracePity_AD.SetActive(true);
        TracePity_AD.transform.localPosition = new Vector3(4652, 0, 0);
        var ADSlot = DOTween.Sequence();
        ADSlot.Append(TracePity_AD.transform.DOLocalMoveX(3101f, 1f).SetEase(Ease.InExpo));
        ADSlot.Append(TracePity_AD.transform.DOLocalMoveX(1550f, 0.5f).SetEase(Ease.Linear));
        ADSlot.Append(TracePity_AD.transform.DOLocalMoveX(-30f, 1f).SetEase(Ease.OutExpo));
        ADSlot.Append(TracePity_AD.transform.DOLocalMoveX(0f,0.4f));
        ADSlot.AppendCallback(() =>
        {
            
            //动画结束 text x2 
            finish();
        });
    }

    /// <summary>
    /// 停止两轴转动进行加速倍数动画
    /// </summary>
    public void PlayLazily() 
    {
        PlayTracePity[0].transform.DOKill();
        PlayTracePity[1].transform.DOKill();
        Tribe = false;
    }
    /// <summary>
    /// 每次打开动画
    /// </summary>
    public void TunePin() 
    {
        /*float delayTime = 0;
        for (int i = 0; i < showList.Count; i++)
        {
            GameObject item = showList[i];
            item.transform.localScale = new Vector3(0, 0, 0);
            item.transform.DOScale(1, 0.4f).SetEase(Ease.OutBack).SetDelay(delayTime);
            delayTime += 0.5f;
        }*/
    }
    /// <summary>
    /// 宝箱打开动画
    /// </summary>
    /// <returns></returns>
    public IEnumerator AbutAxe()
    {
        for (int i = 0; i < FlaxPity.Count; i++)
        {
            GameObject Fare= FlaxPity[i];
            Fare.transform.localScale = new Vector3(0, 0, 0);
            //item.transform.DOScale(1, 0.4f).SetEase(Ease.OutBack).SetDelay(delayTime);
            //delayTime += 0.5f;
        }
        AxeOvert.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        AxeOvert.transform.DOScale(1, 0.4f).SetEase(Ease.OutBack).SetDelay(0);
        SquashLow.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 350);
        yield return new WaitForSeconds(0.7f);
        AxeOvert.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "open", false);
        yield return new WaitForSeconds(1.3f);
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_GetReward);
        SquashLow.SetActive(true);
        SquashLow.transform.localScale = new Vector3(0, 0, 0);
        SquashLow.transform.DOScale(1, 0.3f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.3f);
        AxeOvert.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "open_idel", true);
        //RewardBar.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -150);
        SquashLow.transform.DOLocalMoveY(-300, 0.5f);
        yield return new WaitForSeconds(0.7f);
        SquashLow.transform.DOLocalMoveY(-300, 0.5f);
        
        SquashLow.transform.DOLocalMoveY(150, 0.5f);
        AxeOvert.transform.DOLocalMoveY(450, 0.5f);
        yield return new WaitForSeconds(0.6f);
        float delayTime = 0;
        for (int i = 1; i < FlaxPity.Count; i++)
        {
            GameObject Fare= FlaxPity[i];
            Fare.transform.localScale = new Vector3(0, 0, 0);
            Fare.transform.DOScale(1, 0.4f).SetEase(Ease.OutBack).SetDelay(delayTime);
            delayTime += 0.2f;
        }
    }

    double Crossbreed= 0;
    private void AbsencePlayUI()
    {
        List<MultiplierBox> rewardValue = new List<MultiplierBox>();
        rewardValue = RetoolPity(PryTellOwn.instance.TownWise.BoxInfo.MultiplierInfo);
        
        for (int i = 0; i < PlayStop.Count; i++)
        {
            for (int j = 0; j < PlayStop[i].transform.childCount; j++)
            {
                PlayStop[i].transform.GetChild(j).GetChild(0).GetComponent<Text>().text = "×" + rewardValue[j].Multiplier;
            }
        }
        Crossbreed = double.Parse(TraceEnrichAnewWorship.instance.EraCrossbreed(PryTellOwn.instance.TownWise.BoxInfo.MultiplierInfo).Multiplier);
        CatSquashRail.text = "×" + Crossbreed.ToString();
        
    }
    
    

    private List<T> RetoolPity<T>(List<T> num)
    {
        for (int i = 0; i < num.Count; i++)
        {
            var temp = num[i];
            int randomIndex = UnityEngine.Random.Range(0, num.Count);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        return num;
    }
[UnityEngine.Serialization.FormerlySerializedAs("uiElement")]    
    public List<RectTransform> uiFinnish; // UI元素的RectTransform
[UnityEngine.Serialization.FormerlySerializedAs("controlPoint")]    public List<Vector2> WillfulUnify; // 曲线的控制点
[UnityEngine.Serialization.FormerlySerializedAs("duration")]    public float Innocent= 0.3f; // 从起点到终点的时间

    private float t; // Lerp参数
    void PerSnow()
    {
        t = 0;
        for (int i = 0; i < uiFinnish.Count; i++)
        {
            GameObject Fare= uiFinnish[i].gameObject;
            Fare.gameObject.SetActive(true);
            Fare.transform.localScale = new Vector3(100, 100, 100);
            int B = i;
            float A = 0;
            if (i < 2)
            {
                A = 1;
            }
            else
            {
                A = -1;
            }
            Vector3 MidPos = new Vector3((Fare.transform.position.x + SquashLow.transform.position.x) / 2 + A, (Fare.transform.position.y + SquashLow.transform.position.y) / 2, 0);
            Vector3[] path = SeasonStilt.EraMainlyPity(Fare.transform.position, MidPos, SquashLow.transform.position, 6);
            Fare.transform.DOPath(path, 0.8f).OnComplete(() =>
            {
                Fare.gameObject.SetActive(false);
                if (B == uiFinnish.Count - 1)
                {
                    BoxSquash();
                }
            });
        }
    }
    
    // Update is called once per frame

    Vector2 ProstrateSeasonUnify(float t, Vector2 p0, Vector2 p1, Vector2 p2)
    {
        // 二次贝塞尔曲线计算
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        Vector2 p = uu * p0; // 第一项
        p += 2 * u * t * p1; // 第二项
        p += tt * p2; // 第三项
        return p;
    }


    public void CardBoxFossilize(Transform startTransform, double num)
    {
        EelFossilize(startTransform, DeemTF, DeemTF.gameObject, DeemRail, TraceEnrichTownWiseWorship.EraChlorine().RubRide(), num);
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

    public IEnumerator SureRisk(float time, Action finish)
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
    }
}
