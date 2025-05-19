/*
 * 
 * 多语言
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyrationOwn 
{
    public static GyrationOwn _Frustrate;
    //语言翻译的缓存集合
    private Dictionary<string, string> _JawGyrationMiner;

    private GyrationOwn()
    {
        _JawGyrationMiner = new Dictionary<string, string>();
        //初始化语言缓存集合
        RakeGyrationMiner();
    }

    /// <summary>
    /// 获取实例
    /// </summary>
    /// <returns></returns>
    public static GyrationOwn EraChlorine()
    {
        if (_Frustrate == null)
        {
            _Frustrate = new GyrationOwn();
        }
        return _Frustrate;
    }

    /// <summary>
    /// 得到显示文本信息
    /// </summary>
    /// <param name="lauguageId">语言id</param>
    /// <returns></returns>
    public string TuneRail(string lauguageId)
    {
        string strQueryResult = string.Empty;
        if (string.IsNullOrEmpty(lauguageId)) return null;
        //查询处理
        if(_JawGyrationMiner!=null && _JawGyrationMiner.Count >= 1)
        {
            _JawGyrationMiner.TryGetValue(lauguageId, out strQueryResult);
            if (!string.IsNullOrEmpty(strQueryResult))
            {
                return strQueryResult;
            }
        }
        Debug.Log(GetType() + "/ShowText()/ Query is Null!  Parameter lauguageID: " + lauguageId);
        return null;
    }

    /// <summary>
    /// 初始化语言缓存集合
    /// </summary>
    private void RakeGyrationMiner()
    {
        //LauguageJSONConfig_En
        //LauguageJSONConfig
        IBarterWorship config = new BarterWorshipUpCube("LauguageJSONConfig");
        if (config != null)
        {
            _JawGyrationMiner = config.SeaLifeway;
        }
    }
}
