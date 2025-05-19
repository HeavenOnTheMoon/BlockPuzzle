using System;
using System.Collections;
using System.Collections.Generic;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HyperDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("RewardInfoObjs")]    public List<GameObject> SquashTellObjs;
[UnityEngine.Serialization.FormerlySerializedAs("SelectDaySchImage")]    public Image ZigzagEyeFurTwine;
[UnityEngine.Serialization.FormerlySerializedAs("SpineAni")]    public SkeletonGraphic OvertPin;
[UnityEngine.Serialization.FormerlySerializedAs("SelectDaySchText")]    public Text ZigzagEyeFurRail;
[UnityEngine.Serialization.FormerlySerializedAs("SelectDaySchDicText")]    public Text ZigzagEyeFurJawRail;
[UnityEngine.Serialization.FormerlySerializedAs("BlockBtn")]    public Button TraceSow;
[UnityEngine.Serialization.FormerlySerializedAs("MentalWidgetObj")]
    public GameObject EarnerRenderSum;
[UnityEngine.Serialization.FormerlySerializedAs("scrollRect")]    public ScrollRect CombatMost;  
    // Start is called before the first frame update
    void Start()
    { 
        TraceSow.onClick.AddListener(TraceSowScene);
        /*for (int i = 0; i < MentalWidgetObj.transform.childCount; i++)
        {
            MentalWidgetObj.transform.GetChild(i).GetComponent<TraceEnrichEarnerRender>().Select = MentalClick;
        }*/

        for (int i = 0; i < SquashTellObjs.Count; i++)
        {
            SquashTellObjs[i].GetComponent<TraceEnrichEarnerSquashRender>().AbsenceRail(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int WearerWit= 19;
    public override void Display()
    {
        base.Display();
        UnsungIDRefute();
        
        WearerWit = 19;
        EarnerScene(19);
        AbsenceUI();
    }
    public override void Hidding()
    {
        base.Hidding();
        

    }

    private void TraceSowScene()
    {
        WheelUIPick(GetType().Name);
    }
    public void UnsungIDRefute()
    {
        // 设置verticalNormalizedPosition为0使其滚动到底部
        CombatMost.horizontalNormalizedPosition = 1f;
    }

    private void AbsenceUI()
    {
        for (int i = 0; i < EarnerRenderSum.transform.childCount; i++)
        {
            EarnerRenderSum.transform.GetChild(i).GetComponent<TraceEnrichEarnerRender>().Rake(i + 1);
        }
        
        
    }

    private void EarnerScene(int index)
    {
        //0 ~ 19    before ~ Today
        WearerWit = index;
        var Wish= TraceEnrichAthensWorship.Instance.EraPlusEarnerTell(index);
        float Beg= (float)Wish.Athens / PryTellOwn.instance.TownWise.SourceRewards.dailyMaxSource;
        ZigzagEyeFurRail.text = (Beg * 100).ToString("f0") + "%";
        ZigzagEyeFurTwine.fillAmount = Beg;
        SkeletonGraphic skeleton = OvertPin.GetComponent<SkeletonGraphic>();
        skeleton.AnimationState.SetEmptyAnimation(0, 0);
        OvertPin.AnimationState.SetAnimation(0, "animation", true);
        if (Beg * 100 > 100)
        {
            OvertPin.AnimationState.SetAnimation(1, "100", true);
        }
        else
        {
            OvertPin.AnimationState.SetAnimation(1, (Beg * 100).ToString("f0"), true);
        }
        skeleton.Update(0); 
        if (Beg < 0.25f)
        {
            ZigzagEyeFurJawRail.text = "Conscious";
            AbsenceSquashTell(0);
        }
        else if(Beg >= 0.25f && Beg < 0.5f)
        {
            ZigzagEyeFurJawRail.text = "Conscious";
            AbsenceSquashTell(1);
        }
        else if(Beg >= 0.5f && Beg < 0.75f)
        {
            ZigzagEyeFurJawRail.text = "Clever"; 
            AbsenceSquashTell(2);
        }
        else if(Beg >= 0.75f && Beg < 1f)
        {
            ZigzagEyeFurJawRail.text = "Brain";
            AbsenceSquashTell(3);
        }
        else
        {
            ZigzagEyeFurJawRail.text = "Genius";
            AbsenceSquashTell(4);
        }
    }

    private void AbsenceSquashTell(int index)
    {
        for (int i = 0; i < SquashTellObjs.Count; i++)
        {
            SquashTellObjs[i].GetComponent<TraceEnrichEarnerSquashRender>().AbsenceUI(i >= index);
        }
    }
}
