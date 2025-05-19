using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OliverFlaw
{
   
    public static bool OnCycle()
    {
        return true;//PryTellOwn.instance.ConfigData.apple_pie == "apple";
    }

    /// <summary>
    /// 是否开启AB
    /// </summary>
    /// <returns></returns>
    public static bool OnSpanAB()
    {
        return PryTellOwn.instance.BarterWise.plan_AB == "a";
    }

    public static string TownBull()
    {
        string name = OnSpanAB() ? "TownDelta_A" : "TownDelta";
        return name;
    }

    public static bool OnCrease()
    {
#if UNITY_EDITOR
        return true;
#else
            return false;
#endif
    }

    /// <summary>
    /// 是否为竖屏
    /// </summary>
    /// <returns></returns>
    public static bool OnHumanity()
    {
        return Screen.height > Screen.width;
    }

}
