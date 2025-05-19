using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class QualitativeDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("ScrapingCardWidgets")]    public List<TraceEnrichKeroseneWrapRender> KeroseneWrapEagerly;
[UnityEngine.Serialization.FormerlySerializedAs("RewardObj")]    
    public GameObject SquashSum;
[UnityEngine.Serialization.FormerlySerializedAs("RewardRubObj")]    public GameObject SquashGutSum;
[UnityEngine.Serialization.FormerlySerializedAs("RubObj")]    public GameObject GutSum;
[UnityEngine.Serialization.FormerlySerializedAs("HideCoverBtn")]    public Button WearAmazeSow;

    RewardItem _MakeupPack;
    int type = 0;
    int MakeupCajun= 0;
    int[] GooseSquashHave= new int[16];

    // Start is called before the first frame update
    void Start()
    {
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_ThereSquash, (messageData) =>
        {
            ThereSquash();
        });

        WearAmazeSow.onClick.AddListener(WearSpell);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int OcherCajun= 0;
    public override void Display()
    {
        base.Display();
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Openboard);
        //FailWiseWorship.SetInt(CBarter.sv_ExistScratchCard, 0);
        //FailWiseWorship.SetInt(CBarter.sv_ExistScratchCard, 0);
        //AgreeOwn.GetInstance().PlayEffect(AgreeFirm.UIMusic.WordHikeSound_ScratCardPanel);
        AbsenceGutTwine();
        OcherCajun = 0;
        _MakeupPack = TraceEnrichAnewWorship.instance.EraSquashFirm(PryTellOwn.instance.TownWise.ScratchInfo.ScratchRewardInfo);
        type = _MakeupPack.type == "cash" ? 0 : 1;
        FailWiseWorship.FatThrive(CBarter.My_SquashFirm, _MakeupPack.type);
        MakeupCajun = TraceEnrichAnewWorship.instance.EraScrStick(PryTellOwn.instance.TownWise.ScratchInfo.ScratchCountInfo);
        FatSquashStick(PryTellOwn.instance.TownWise.ScratchInfo.ScratchCountInfo, PryTellOwn.instance.TownWise.ScratchInfo.ScratchRewardInfo, type);
        AbsenceSquash();
        SquashSum.GetComponent<TraceEnrichKeroseneWrapRender>().Rake(type);
        for (int i = 0; i < KeroseneWrapEagerly.Count; i++)
        {
            KeroseneWrapEagerly[i].Rake(GooseSquashHave[i]);
            KeroseneWrapEagerly[i].Shovel(false);
        }
    }
    
    public override void Hidding()
    {
        base.Hidding();
        for (int i = 0; i < GooseSquashHave.Length; i++)
        {
            KeroseneWrapEagerly[i].Shovel(false);
        }
    }
    
    
    private void AbsenceGutTwine()
    {
        GutSum.GetComponent<TraceEnrichGutPigTwineInsatiable>().RakeAmaze();
    }
    
    private void ThereSquash()
    {
        if (GutSum.GetComponent<TraceEnrichGutPigTwineInsatiable>().WeCatRubble)
        {
            OcherCajun++;
            StartCoroutine(Pin());
        }
    }

    IEnumerator Pin()
    {
        yield return new WaitForSeconds(0.3f);
        for (int i = 0; i < GooseSquashHave.Length; i++)
        {
            if (GooseSquashHave[i] == type)
            {
                KeroseneWrapEagerly[i].Shovel(true);
                yield return new WaitForSeconds(0.3f);
            }
        }
        yield return new WaitForSeconds(0.8f);
        //AgreeOwn.GetInstance().PlayEffect(AgreeFirm.UIMusic.WordHikeSound_CompleteScratCard);
        TuneDelta();

    }
    private void TuneDelta()
    {
        AbutUIPick("SquashDelta"); 
        AbsenceGutTwine();
        WheelUIPick(GetType().Name);
    }

    int[] MakeupHave;
    private void AbsenceSquash()
    {
        MakeupHave = new int[]{0,1,2,3,4,5};
        
        
        /*for (int i = 0; i < rewardPool.Length; i++)
        {
            if (rewardPool[i] == type)
            {
                rewardPool[i] = 6;
            }
        }*/
        
        for (int i = 0; i < 16; i++)
        {
            if (i < MakeupCajun)
            {
                GooseSquashHave[i] = type;
            }
            else
            {
                GooseSquashHave[i] = EraSquashFirm(type); //rewardPool[Random.Range(2, 6)];
            }
            
            //TotalRewardPool[i] = i < rewardCount ? type == 1 ? 1 : 0 : type == 1 ? 0 : 1;
        }

        GooseSquashHave = EraOneRetoolKnap(GooseSquashHave);
    }

    private int EraSquashFirm(int index)
    {
        int Create= Random.Range(0, 6);
        if (Create == index)
        {
            return EraSquashFirm(index);
        }
        return Create;
    }
    
    public int[] EraOneRetoolKnap(int[] num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            var temp = num[i];
            int randomIndex = RetoolStick(0, num.Length);
            num[i] = num[randomIndex];
            num[randomIndex] = temp;
        }
        return num;
    }
    
    private int RetoolStick(int min, int max)
    {
        return Random.Range(min, max);
    }
    
    public void FatSquashStick(List<ScraCount> rewardInfos, List<RewardItem> rewardTwoInfos,int type)
    {
        double value = 0;
        switch (type)
        {
            case 0 : value = BlockPuzzleGameUtil.GetCashMulti() * double.Parse(rewardInfos[0].multi) * double.Parse(rewardTwoInfos[0].multiple); break;
            case 1 : value = BlockPuzzleGameUtil.GetGoldMulti() * double.Parse(rewardInfos[1].multi) * double.Parse(rewardTwoInfos[1].multiple); break;
            
        }
        FailWiseWorship.FatThrive(CBarter.My_SquashStick, value.ToString());
    }


    private void WearSpell()
    {
        GutSum.GetComponent<TraceEnrichGutPigTwineInsatiable>().CannonAmaze();
    }
}
