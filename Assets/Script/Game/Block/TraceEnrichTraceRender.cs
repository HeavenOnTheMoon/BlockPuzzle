using DG.Tweening;
using Spine;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class TraceEnrichTraceRender : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("BlockImage")]    public Image TraceTwine;
[UnityEngine.Serialization.FormerlySerializedAs("SelectImage")]    public Image ZigzagTwine;
[UnityEngine.Serialization.FormerlySerializedAs("CanComPleteImage")]    public Image BisBegBiomeTwine;
[UnityEngine.Serialization.FormerlySerializedAs("ClearObj")]    public GameObject BlameSum;
[UnityEngine.Serialization.FormerlySerializedAs("FlyEffect")]    public List<GameObject> PerEscape;
[UnityEngine.Serialization.FormerlySerializedAs("spine")]
    public SkeletonGraphic Stock;
[UnityEngine.Serialization.FormerlySerializedAs("X")]    public int X;
[UnityEngine.Serialization.FormerlySerializedAs("Y")]    public int Y;
    public int Type;

    public BlockColor color;
    private BlockColor AffinityPluck;
[UnityEngine.Serialization.FormerlySerializedAs("RewardImage")]
    public Image SquashTwine;
[UnityEngine.Serialization.FormerlySerializedAs("GoldAppearSpine")]    public SkeletonGraphic RideForgetOvert;
[UnityEngine.Serialization.FormerlySerializedAs("CashAppearSpine")]    public SkeletonGraphic FareForgetOvert;
[UnityEngine.Serialization.FormerlySerializedAs("rewardType")]
    public int MakeupFirm;     // 棋盘初始时随机放置奖励，0：没有奖励；1：现金奖励；2：金币奖励
    private RewardItem Makeup;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void Rake(int x, int y, int index, BlockColor color)
    {
        X = x;
        Y = y;
        Type = index;
        this.color = color;
        AffinityPluck = color;
        TuneTwine(index);
        TraceTwine.transform.localPosition = new Vector3(0, 7, 0);
        TraceTwine.transform.localScale = new Vector3(1, 1, 1);
        TraceTwine.color = new Color(1, 1, 1, 1);
    }
    
    // 空棋盘上随机放置奖励
    public void FatSquashFirmRetool()
    {
        if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) != 99 || Type != 0 || OliverFlaw.OnCycle())
        {
            MakeupFirm = 0;
            return;
        }

        if (MakeupFirm != 0)
        {
            return;
        }

        //int rewardBlockNum = TraceEnrichGypsySaladWorship.Instance.CheckBoardInfo
        //    .Where(x => x.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Type == 0 && x.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().rewardType != 0)
        //    .Count();
        //if (rewardBlockNum >= PryTellOwn.instance.GameData.RewardBlockNumLimit)
        //{
        //    return;
        //}

        Makeup = RetoolFlaw.EraAcceptRetool(PryTellOwn.instance.TownWise.BlockReward.ToArray(), PryTellOwn.instance.TownWise.BlockReward.Select(x => x.weight).ToArray());

        if (Makeup.type == "cash")
        {
            MakeupFirm = 1;
        }
        else if (Makeup.type == "coin")
        {
            MakeupFirm = 2;
        }
        else
        {
            MakeupFirm = 0;
        }

        TuneSquashTwine();

    }

    private void TuneSquashTwine()
    {
        if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) != 99 || Type != 0)
        {
            MakeupFirm = 0;
            SquashTwine.gameObject.SetActive(false);
            return;
        }

        if (MakeupFirm == 1 || MakeupFirm == 2)
        {
            if (!SquashTwine.gameObject.activeSelf)
            {
                if (MakeupFirm == 1)
                {
                    FareForgetOvert.gameObject.SetActive(true);
                    FareForgetOvert.AnimationState.SetAnimation(0, "animation", false);
                }
                else if (MakeupFirm == 2)
                {
                    RideForgetOvert.gameObject.SetActive(true);
                    RideForgetOvert.AnimationState.SetAnimation(0, "animation", false);
                }
                StartCoroutine(nameof(TuneSquashTwineRelaxOvert));
            }
        }
        else
        {
            SquashTwine.gameObject.SetActive(false);
        }
    }
    
    private IEnumerator TuneSquashTwineRelaxOvert()
    {
        yield return new WaitForSeconds(0.5f);
        SquashTwine.GetComponent<RectTransform>().localScale = Vector3.zero;
        SquashTwine.sprite = MakeupFirm == 1 ? TraceEnrichTraceWorship.Instance.TraceSprites[7] : TraceEnrichTraceWorship.Instance.TraceSprites[8];
        SquashTwine.gameObject.SetActive(true);
        SquashTwine.GetComponent<RectTransform>().DOScale(1, 0.2f);
    }

    // 可放置提示
    public void TuneZigzag(bool isShow, int type = 0, BlockColor color = BlockColor.Red)
    {
        if (!isShow || type == 0)
        {
            ZigzagTwine.gameObject.SetActive(false);
        }
        else
        {
            ZigzagTwine.sprite = EraSubwayUpFirm(type, color);
            ZigzagTwine.gameObject.SetActive(true);
        }
    }

    // 可消除提示
    public void TuneBisBegBiomeTwine(bool isShow, BlockColor color = BlockColor.Red)
    {
        if(Type == -1 || Type == 99)
            return;
        

        if (ZigzagTwine.gameObject.activeSelf)
        {
            return;
        }

        if (isShow && Type == 1)
        {
            this.color = color;
            TuneTwine(1, false);
        }
        else
        {
            this.color = AffinityPluck;
            TuneTwine(Type);
        }
    }

    public void TuneTraceTwine(bool isShow, int index, BlockColor color = BlockColor.Red, bool checkReward = false)
    {
        this.color = color;
        AffinityPluck = color;
        if (isShow)
        {
            if (checkReward)
            {
                if (MakeupFirm == 1)
                {
                    double rewardValue = BlockPuzzleGameUtil.GetCashMulti() * double.Parse(Makeup.multiple);
                    TraceEnrichTownWiseWorship.EraChlorine().EelBriny(rewardValue, transform);
                }
                else if (MakeupFirm == 2)
                {
                    double rewardValue = BlockPuzzleGameUtil.GetGoldMulti() * double.Parse(Makeup.multiple);
                    TraceEnrichTownWiseWorship.EraChlorine().EelRide(rewardValue, transform);
                }
                MakeupFirm = 0;
            }
            Type = index;
            TuneTwine(index);
            TraceTwine.gameObject.SetActive(true);
        }
        else
        {
            Type = 0;
            TuneTwine(0);
        }
    }
    
    public void TuneTwine(int index, bool changeType = true)
    {
        TraceTwine.gameObject.SetActive(true);
        TraceTwine.sprite = TraceEnrichTraceWorship.Instance.TraceSprites[0];
        if (changeType) Type = index;
        if (index == -1)
        {
            TraceTwine.gameObject.SetActive(false);
        }
        else if (index == 0)
        {
            TraceTwine.gameObject.SetActive(false);
        }
        else
        {
            TraceTwine.sprite = EraSubwayUpFirm(index, color);
        }

        TuneSquashTwine();
    }

    private Sprite EraSubwayUpFirm(int _type, BlockColor _color)
    {
        Sprite sprite = null;
        switch (_type)
        {
            case -1:
                sprite = null;
                break;
            case 0:
                sprite = null;
                break;
            case 1:
                sprite = OliverFlaw.OnSpanAB()? TraceEnrichTraceWorship.Instance.PluckTraceLightly_A[(int)_color]: TraceEnrichTraceWorship.Instance.PluckTraceLightly[(int)_color];
                break;
            case 2:
                sprite = TraceEnrichTraceWorship.Instance.TraceSprites[1];
                break;
            case 3:
                sprite = TraceEnrichTraceWorship.Instance.TraceSprites[2];
                break;
            case 4:
                sprite = TraceEnrichTraceWorship.Instance.TraceSprites[3];
                break;
            case 5:
                sprite = TraceEnrichTraceWorship.Instance.TraceSprites[4];
                break;
            case 6:
                sprite = TraceEnrichTraceWorship.Instance.TraceSprites[5];
                break;
            case 7:
                sprite = TraceEnrichTraceWorship.Instance.TraceSprites[5];
                break;
            case 8:
                sprite = TraceEnrichTraceWorship.Instance.TraceSprites[5];
                break;
            case 9:
                sprite = TraceEnrichTraceWorship.Instance.TraceSprites[5];
                break;
            case 99:
                sprite = TraceEnrichTraceWorship.Instance.TraceSprites[6];
                break;

        }
        return sprite;
    }

    public void BlameTrace()
    {
        TraceEnrichParisWorship.Instance.AcidicStrict(Type);
        Type = 0;
        MakeupFirm = 0;
        gameObject.SetActive(false);
    }

    public void BlameFossilize(List<GameObject> InsTF, Action finish)
    {
        BlameSum.gameObject.SetActive(true);
        if (Type != 99)
        {
            Stock.gameObject.SetActive(true);
            SkeletonGraphic skeleton = Stock.gameObject.GetComponent<SkeletonGraphic>();
            skeleton.AnimationState.SetEmptyAnimation(0, 0);
            skeleton.AnimationState.SetAnimation(0, "animation", true);
            skeleton.Update(0);

            TraceTwine.transform.DOScale(1.1f, 0.1f).SetEase(Ease.InOutSine).OnComplete(() =>
            {
                TraceTwine.transform.DOScale(0, 0.2f).SetEase(Ease.InOutSine).OnComplete(() =>
                {
                    Stock.gameObject.SetActive(false);
                    BlameSum.gameObject.SetActive(false);
                    TraceTwine.transform.localScale = new Vector3(1, 1, 1);
                    TraceTwine.color = new Color(1, 1, 1, 1);
                    
                    finish?.Invoke();
                });
            });

            if (Type != 1)
            {
                //ClearObj.gameObject.SetActive(false);
                GameObject SpItem = Instantiate(gameObject, transform.parent);
                if (Type > 1)
                {
                    SpItem.GetComponent<TraceEnrichTraceRender>().TraceTwine.GetComponent<Image>().sprite = TraceEnrichTraceWorship.Instance.TraceStrictLightly[Type - 2];
                    SpItem.GetComponent<TraceEnrichTraceRender>().Stock.gameObject.SetActive(false);
                }
                SpItem.transform.position = transform.position;
                SpItem.AddComponent<Canvas>().overrideSorting = true;
                SpItem.GetComponent<Canvas>().sortingOrder = 110;
                InsTF.Add(SpItem);
            }
        }
        else
        {
            BlameSum.gameObject.SetActive(false);
            GameObject SpItem = Instantiate(gameObject, transform.parent);
            SpItem.transform.position = transform.position;
            InsTF.Add(SpItem);
            finish?.Invoke();
        }

    }
}
