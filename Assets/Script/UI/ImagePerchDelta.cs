using System;
using System.Collections.Generic;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class ImagePerchDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("FreeSpinBtn")]    public Button PullEnvySow;
[UnityEngine.Serialization.FormerlySerializedAs("RewardObjs")]    public List<GameObject> SquashStop;
[UnityEngine.Serialization.FormerlySerializedAs("WheelObj")]    public GameObject PerchSum;    
[UnityEngine.Serialization.FormerlySerializedAs("EffectObj")]    public GameObject EscapeSum;
[UnityEngine.Serialization.FormerlySerializedAs("WheelSpineAni")]    public SkeletonGraphic PerchOvertPin;
    //public SkeletonAnimation LightSpineAni;

    double[] Lumiere= new double[6];
    int EraSquashFirm= 0;
    int ZincSweaty= 0;
    // Start is called before the first frame update
    void Start()
    {
        PullEnvySow.onClick.AddListener(PullEnvySowScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Display()
    {
        base.Display();
        EscapeSum.gameObject.SetActive(false);
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Openboard);
        PullEnvySow.gameObject.SetActive(true);
        EraSquashFirm = 0;
        PerchOvertPin.AnimationState.SetAnimation(0, "1", true);

        AbsenceSquash();
        AbsenceSquashUI();
        FatCenozoicAllay(256, 6);
    }
    public override void Hidding()
    {
        base.Hidding();
        
    }

    private void PullEnvySowScene()
    {
        PullEnvySow.gameObject.SetActive(false);
        PerchOvertPin.AnimationState.SetAnimation(0, "2", false);
        EnvyPin(() =>
        {
            WheelUIPick(GetType().Name);
        });
    }

    private void WheelSowScene()
    {
        WheelUIPick(GetType().Name);
    }

    private void EnvyPin(Action finish = null)
    { 
        var rewardItem = TraceEnrichAnewWorship.instance.EraSquashFirm(PryTellOwn.instance.TownWise.WheelReward.Reward);
        FailWiseWorship.FatThrive(CBarter.My_SquashFirm, rewardItem.type);
        
        FailWiseWorship.FatThrive(CBarter.My_SquashStick, Lumiere[rewardItem.id].ToString());
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_SchFillamount);
        PerchSum.transform.DOLocalRotate(new Vector3(0, 0, -360 * 6 - 60 * rewardItem.id), 2.5f).OnComplete(() =>
        {
            PerchOvertPin.AnimationState.SetAnimation(0, "3", false);
            //LightSpineAni.AnimationState.SetAnimation(0, "1", false);
            EscapeSum.gameObject.SetActive(true);
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_WheelFinish);
            PerchSum.transform.DOScale(1, 1.5f).OnComplete(() =>
            {
                finish?.Invoke();
                TraceEnrichAnewWorship.instance.BlamePerchFur();
                UIWorship.EraChlorine().TuneUIAware("SquashDelta");
            });
            
        });
    }

    private void AbsenceSquash()
    {
        for (int i = 0; i < SquashStop.Count; i++)
        {
            if (PryTellOwn.instance.TownWise.WheelReward.Reward[i].type == "cash")
            {
                Lumiere[i] = BlockPuzzleGameUtil.GetCashMulti() * double.Parse(PryTellOwn.instance.TownWise.WheelReward.Reward[i].multiple);
                
            }
            else
            {
                Lumiere[i] = BlockPuzzleGameUtil.GetGoldMulti() * double.Parse(PryTellOwn.instance.TownWise.WheelReward.Reward[i].multiple);
            }
        }
    }

    private void AbsenceSquashUI()
    {
        for (int i = 0; i < SquashStop.Count; i++)
        {
            if (PryTellOwn.instance.TownWise.WheelReward.Reward[i].type == "cash")
            {
                SquashStop[i].transform.GetChild(0).gameObject.SetActive(false);
                SquashStop[i].transform.GetChild(1).gameObject.SetActive(true);
                SquashStop[i].transform.GetChild(1).Find("Text").GetComponent<Text>().text = BrightFlaw.PotatoIDGin(Lumiere[i]);
            }
            else
            {
                SquashStop[i].transform.GetChild(0).gameObject.SetActive(true);
                SquashStop[i].transform.GetChild(0).Find("Text").GetComponent<Text>().text = BrightFlaw.PotatoIDGin(Lumiere[i]);
                SquashStop[i].transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }

    /// <summary>
    /// 修改奖品位置
    /// </summary>
    /// <param name="radius">半径（奖品距离圆心的距离）</param>
    /// <param name="num">总的奖品数量</param>
    /// <returns></returns>
    private List<GameObject> FatCenozoicAllay(float radius, int num)
    {
        List<GameObject> items = new();
        float angleIncrement = 360f / num; // 每个点之间的角度增量
        for (int i = 0; i < num; i++)
        {
            float angle = -90f + i * angleIncrement; // 从圆底部开始，逆时针计算角度  
            float angleInRadians = angle * Mathf.Deg2Rad; // 将角度转换为弧度  

            // 计算x和y坐标  
            float x = Mathf.Cos(angleInRadians) * radius;
            float y = Mathf.Sin(angleInRadians) * radius;

            GameObject Fare= SquashStop[i];
            Fare.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
            // 沿z轴旋转
            Fare.GetComponent<RectTransform>().localRotation = Quaternion.AngleAxis(i * angleIncrement, Vector3.forward);
            Fare.SetActive(true);
            items.Add(Fare);
        }
        return items;
    }
}


