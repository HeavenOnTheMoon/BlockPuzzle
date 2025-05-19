using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TraceEnrichEarnerSquashRender : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public Text FareRail;
[UnityEngine.Serialization.FormerlySerializedAs("CashObj")]    public GameObject FareSum;
[UnityEngine.Serialization.FormerlySerializedAs("ComPleteObj")]    public GameObject BegBiomeSum;
[UnityEngine.Serialization.FormerlySerializedAs("UnCompleteObj")]    public GameObject UnFeldsparSum;
[UnityEngine.Serialization.FormerlySerializedAs("OkObj")]    public GameObject OkSum;
[UnityEngine.Serialization.FormerlySerializedAs("CoinObj")]    public GameObject DeemSum;
[UnityEngine.Serialization.FormerlySerializedAs("CoinText")]    public Text DeemRail;
    public void AbsenceRail(int index)
    {
        int value = 0;
        switch (index)
        {
            case 0:
                value = PryTellOwn.instance.TownWise.SourceRewards.oneQuarter;
                break;
            case 1:
                value = PryTellOwn.instance.TownWise.SourceRewards.twoQuarter;
                break;
            case 2:
                value = PryTellOwn.instance.TownWise.SourceRewards.threeQuarter;
                break;
            case 3:
                value = PryTellOwn.instance.TownWise.SourceRewards.fourQuarter;
                break;
        }

        FareRail.text = value.ToString();
    }

    public void AbsenceUI(bool IsComplete)
    {
        //审核
        if (OliverFlaw.OnCycle())
        {
            DeemSum.gameObject.SetActive(IsComplete);
            DeemRail.text = "1000";
            FareSum.gameObject.SetActive(false);
        }
        else
        {
            DeemSum.gameObject.SetActive(false);
            FareSum.gameObject.SetActive(IsComplete);
        }
        //CashObj.gameObject.SetActive(IsComplete);
        BegBiomeSum.gameObject.SetActive(!IsComplete);
        UnFeldsparSum.gameObject.SetActive(IsComplete);
        OkSum.gameObject.SetActive(!IsComplete);
    }
}
