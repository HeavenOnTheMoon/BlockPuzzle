using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceEnrichTownWiseWorship : CoatOutnumber<TraceEnrichTownWiseWorship>
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RakeTownWise()
    {

    }

    // 金币
    public double RubRide()
    {

        return FailWiseWorship.EraPotato(CBarter.My_RideDeem);
    }

    public void EelRide(double gold)
    {
        EelRide(gold, TraceEnrichAnewWorship.instance.transform);
    }

    public void EelRide(double gold, Transform startTransform)
    {
        double oldGold = FailWiseWorship.EraPotato(CBarter.My_RideDeem);
        FailWiseWorship.FatPotato(CBarter.My_RideDeem, oldGold + gold);
        if (gold > 0)
        {
            FailWiseWorship.FatPotato(CBarter.My_NeurosporaRideDeem, FailWiseWorship.EraPotato(CBarter.My_NeurosporaRideDeem) + gold);
        }
        AnemoneWise md = new AnemoneWise(oldGold);
        md.OliveExcursion = startTransform;
        AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_Up_Pigment, md);
    }
    
    // 现金
    public double RubBriny()
    {
        return FailWiseWorship.EraPotato(CBarter.My_Briny);
    }

    public void EelBriny(double token)
    {
        EelBriny(token, TraceEnrichAnewWorship.instance.transform);
    }
    public void EelBriny(double token, Transform startTransform)
    {
        double oldToken = PlayerPrefs.HasKey(CBarter.My_Briny) ? double.Parse(FailWiseWorship.EraThrive(CBarter.My_Briny)) : 0;
        double newToken = oldToken + token;
        FailWiseWorship.FatPotato(CBarter.My_Briny, newToken);
        if (token > 0)
        {
            double allToken = FailWiseWorship.EraPotato(CBarter.My_NeurosporaBriny);
            FailWiseWorship.FatPotato(CBarter.My_NeurosporaBriny, allToken + token);
        }

        AnemoneWise md = new AnemoneWise(oldToken);
        md.OliveExcursion = startTransform;
        AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_Up_Director, md);
    }
    
    public void EelBrinyPig(double token, Transform startTransform, Transform bottomTransform)
    {
        double oldToken = PlayerPrefs.HasKey(CBarter.My_Briny) ? double.Parse(FailWiseWorship.EraThrive(CBarter.My_Briny)) : 0;
        double newToken = oldToken + token;
        FailWiseWorship.FatPotato(CBarter.My_Briny, newToken);
        if (token > 0)
        {
            double allToken = FailWiseWorship.EraPotato(CBarter.My_NeurosporaBriny);
            FailWiseWorship.FatPotato(CBarter.My_NeurosporaBriny, allToken + token);
        }

        AnemoneWise md = new AnemoneWise(oldToken);
        md.OliveExcursion = startTransform;
        md.Olive2Excursion = bottomTransform;
        AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_Up_DirectorFlannel, md);
    }

    //Amazon卡
    public double RubAccord()
    {
        return FailWiseWorship.EraPotato(CBarter.My_Accord);
    }

    public void EelAccord(double amazon)
    {
        EelAccord(amazon, TraceEnrichAnewWorship.instance.transform);
    }
    public void EelAccord(double amazon, Transform startTransform)
    {
        double oldAmazon = PlayerPrefs.HasKey(CBarter.My_Accord) ? double.Parse(FailWiseWorship.EraThrive(CBarter.My_Accord)) : 0;
        double newAmazon = oldAmazon + amazon;
        FailWiseWorship.FatPotato(CBarter.My_Accord, newAmazon);
        if (amazon > 0)
        {
            double allAmazon = FailWiseWorship.EraPotato(CBarter.My_NeurosporaAccord);
            FailWiseWorship.FatPotato(CBarter.My_NeurosporaAccord, allAmazon + amazon);
        }
        AnemoneWise md = new AnemoneWise(oldAmazon);
        md.OliveExcursion = startTransform;
        AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_Up_Retentive, md);
    }
}
