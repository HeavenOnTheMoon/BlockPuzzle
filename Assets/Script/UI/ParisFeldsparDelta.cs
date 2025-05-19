using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParisFeldsparDelta : TineUIAware
{
    [Header("按钮")]
[UnityEngine.Serialization.FormerlySerializedAs("ADButton")]    public Button ADShould;
[UnityEngine.Serialization.FormerlySerializedAs("NextLevelButton")]    public Button TheyParisShould;
[UnityEngine.Serialization.FormerlySerializedAs("ADText")]    public GameObject ADRail;
    [Header("转盘组")]
[UnityEngine.Serialization.FormerlySerializedAs("SlotBG")]    public PlayLiter PlayBG;
[UnityEngine.Serialization.FormerlySerializedAs("RewardCashImage")]
    public GameObject SquashFareTwine;
[UnityEngine.Serialization.FormerlySerializedAs("RewardGoldImage")]    public GameObject SquashRideTwine;
[UnityEngine.Serialization.FormerlySerializedAs("RewardText")]    public Text SquashRail;

    private double rewardValue;
    private bool CuePickaxeUpSow;

    // Start is called before the first frame update
    void Start()
    {
        ADShould.onClick.AddListener(() => {
            if (WeSowJade())
            {
                RichPlay();
            }
            else
            {
                ADManager.Instance.playRewardVideo((success) =>
                {
                    if (success)
                    {
                        //广告
                        RichPlay();
                    }
                }, "101");
                
            }
        });

        TheyParisShould.onClick.AddListener(() =>
        {
            TheyParisShould.enabled = false;
            if (OliverFlaw.OnCycle())
            {
                TraceEnrichTownWiseWorship.EraChlorine().EelRide(rewardValue, transform);
            }
            else
            {
                TraceEnrichTownWiseWorship.EraChlorine().EelBriny(rewardValue, transform);
            }
            WheelUIPick(GetType().Name);
            if (!CuePickaxeUpSow)
            {
                ADManager.Instance.NoThanksAddCount();
            }
        });

    }

    public override void Display()
    {
        base.Display();

        if (WeSowJade())
        {
            ADRail.SetActive(false);
            TheyParisShould.gameObject.SetActive(false);
        }
        else
        {
            ADRail.SetActive(true);
            TheyParisShould.gameObject.SetActive(true);
        }
        TheyParisShould.enabled = true;

        ADShould.gameObject.SetActive(true);
        CuePickaxeUpSow = false;

        // 根据实际项目计算奖励
        //rewardValue = OliverFlaw.IsApple() ? PryTellOwn.instance.InitData.box_gold_price * BlockPuzzleGameUtil.GetGoldMulti() : PryTellOwn.instance.InitData.passlevel_cash_price * BlockPuzzleGameUtil.GetCashMulti();
        rewardValue = 1 * BlockPuzzleGameUtil.GetCashMulti();
        SquashFareTwine.SetActive(!OliverFlaw.OnCycle());
        SquashRideTwine.SetActive(OliverFlaw.OnCycle());
        SquashRail.text = "+" + BrightFlaw.PotatoIDGin(rewardValue);

        PlayBG.VineGenre();
    }

    private bool WeSowJade()
    {
        return !PlayerPrefs.HasKey(CBarter.My_VersePlay + "Bool") || FailWiseWorship.EraKnow(CBarter.My_VersePlay);
    }
    // 计算本次slot应该获得的奖励
    private int RubPlayGenreMatch()
    {
        // 新用户，第一次固定翻5倍
        if (WeSowJade())
        {
            int Route= 0;
            foreach (SlotItem wg in PryTellOwn.instance.RakeWise.slot_group)
            {
                if (wg.multi == 5)
                {
                    return Route;
                }
                Route++;
            }
        }
        else
        {
            int sumWeight = 0;
            foreach (SlotItem wg in PryTellOwn.instance.RakeWise.slot_group)
            {
                sumWeight += wg.weight;
            }
            int r = Random.Range(0, sumWeight);
            int nowWeight = 0;
            int Route= 0;
            foreach (SlotItem wg in PryTellOwn.instance.RakeWise.slot_group)
            {
                nowWeight += wg.weight;
                if (nowWeight > r)
                {
                    return Route;
                }
                Route++;
            }

        }
        return 0;
    }


    private void RichPlay()
    {
        TheyParisShould.gameObject.SetActive(false);
        ADShould.gameObject.SetActive(false);
        int Route= RubPlayGenreMatch();
        PlayBG.Step(Route, (multi) => {
            // slot结束后的回调
            
            /*FossilizeInsatiable.ChangeNumber(rewardValue, rewardValue * multi, 0, RewardText, "+", () =>
            {
                rewardValue = rewardValue * multi;
                RewardText.text = "+" + BrightFlaw.DoubleToStr(rewardValue);
                hasClickedAdBtn = true;
                NextLevelButton.gameObject.SetActive(true);
            });*/
        });

        FailWiseWorship.FatKnow(CBarter.My_VersePlay, false);
    }
}
