using System;
using System.Collections;
using System.Configuration;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SolidDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("CircleGuidanceObj")]    public GameObject LoosenMultiplySum;
[UnityEngine.Serialization.FormerlySerializedAs("RectGuidanceObj")]    public GameObject MostMultiplySum;
[UnityEngine.Serialization.FormerlySerializedAs("GuideText")]    public TextMeshProUGUI SolidRail;
[UnityEngine.Serialization.FormerlySerializedAs("GuideTwoText")]    public TextMeshProUGUI SolidPigRail;
[UnityEngine.Serialization.FormerlySerializedAs("MaskBtn")]    public Button FeatSow;
    /*
    public TextMeshProUGUI GuideText;
    public TextMeshProUGUI GuideTwoText;
    public GameObject HandObj;
    public Canvas Canvas;*/
    // Start is called before the first frame update
    void Start()
    {
        FeatSow.onClick.AddListener(() =>
        {
            SolidRail.transform.parent.gameObject.SetActive(false);
            FeatSow.gameObject.SetActive(false);
            FailWiseWorship.FatWit(CBarter.My_SolidTownFur, 1);
            SolidRail.text = "Cash out in store!";
            //var target = TownDelta.Instance.SOHOShopButton.gameObject.GetComponent<Image>();

            //CircleGuidanceObj.SetActive(true);
            //CircleGuidanceObj.GetComponent<TraceEnrichLoosenMultiply>().Init(target);
            SolidPigRail.transform.parent.gameObject.SetActive(true);
            FossilizeInsatiable.VasTune(SolidPigRail.transform.parent.parent.gameObject, () =>
            {

            });
        });
        
        AnemoneEncaseFiber.EraChlorine().Disprove(CBarter.Of_WheelAndComSolid, (messageData) =>
        {
            WheelDelta();
        }); 
       
    }

    float Park= 0;
    // Update is called once per frame
    void Update()
    {
        
    }

    int Beg;
    public override void Display()
    {
        base.Display();
        /*
       
        MaskBtn.gameObject.SetActive(false);*/
        SolidPigRail.transform.parent.gameObject.SetActive(false);
        LoosenMultiplySum.gameObject.SetActive(false);
        MostMultiplySum.gameObject.SetActive(false);
        SolidRail.transform.parent.gameObject.SetActive(false);
        FeatSow.gameObject.SetActive(false);
        Beg = 3;// GuideManager.instance.GetGuideSch(FailWiseWorship.GetInt(CBarter.sv_GuideSch));
        //HandObj.gameObject.SetActive(false);
        //还没有开始
        /*if (FailWiseWorship.GetInt(CBarter.sv_GuideHomeSch) == 0)
        {
            var target = TwigDelta.instance.ClassicBtn.gameObject.GetComponent<Image>();
            StartCoroutine(GuideTimeLate(0.5f, () =>
            {
                CircleGuidanceObj.SetActive(true);
                CircleGuidanceObj.GetComponent<TraceEnrichLoosenMultiply>().Init(target);
                
            },0.5f,(() =>
            {
                /*GuideText.transform.parent.gameObject.SetActive(true);
                GuideText.transform.parent.parent.gameObject.SetActive(true);
                FossilizeInsatiable.PopShow(GuideText.transform.parent.parent.gameObject, () =>
                {

                });#1#
            })));
        }
        else */
        if(FailWiseWorship.EraWit(CBarter.My_SolidTownFur) == 0)
        {
            FeatSow.gameObject.SetActive(true);
            SolidRail.text = "Crush block to get cash!";
            var Logger= TownDelta.Instance.FareTF.transform.parent.gameObject.GetComponent<Image>();
            LoosenMultiplySum.SetActive(true);
            LoosenMultiplySum.GetComponent<TraceEnrichLoosenMultiply>().Rake(Logger);
            SolidRail.transform.parent.gameObject.SetActive(true);
            FossilizeInsatiable.VasTune(SolidRail.transform.parent.parent.gameObject, () =>
            {

            });
        }
    }
    
    public override void Hidding()
    {
        base.Hidding();
    }
    
    IEnumerator SolidSureRisk(float time, Action finish, float timeTwo = 0, Action finishTow = null)
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
        yield return new WaitForSeconds(timeTwo);
        finishTow?.Invoke();
    }

    private void WheelDelta()
    {
        WheelUIPick(GetType().Name);
    }
}
