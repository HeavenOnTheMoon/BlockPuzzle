using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPuzzleGameUtil
{
    /// <summary>
    /// 获取multi系数
    /// </summary>
    /// <returns></returns>
    private static double GetMulti(RewardType type, double cumulative, MultiGroup[] multiGroup)
    {
        foreach (MultiGroup item in multiGroup)
        {
            if (item.max > cumulative)
            {
                if (type == RewardType.Cash)
                {
                    float random = Random.Range((float.Parse(PryTellOwn.instance.RakeWise.cash_random[0])), (float.Parse(PryTellOwn.instance.RakeWise.cash_random[1])));
                    return item.multi * (1 + random);
                }
                else
                {
                    return item.multi;
                }
            }
        }
        return 1;
    }

    public static double GetGoldMulti()
    {
        return GetMulti(RewardType.Gold, FailWiseWorship.EraPotato(CBarter.My_NeurosporaRideDeem), PryTellOwn.instance.RakeWise.gold_group);
    }

    public static double GetCashMulti()
    {
        return GetMulti(RewardType.Cash, FailWiseWorship.EraPotato(CBarter.My_NeurosporaBriny), PryTellOwn.instance.RakeWise.cash_group);
    }
    public static double GetAmazonMulti()
    {
        return GetMulti(RewardType.Amazon, FailWiseWorship.EraPotato(CBarter.My_NeurosporaAccord), PryTellOwn.instance.RakeWise.amazon_group);
    }
}


/// <summary>
/// 奖励类型
/// </summary>
public enum RewardType { Gold, Cash, Amazon }
