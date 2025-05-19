/**
 * 
 * 网络请求的post对象
 * 
 * ***/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class PryYarnTripPoison 
{
    //post请求地址
    public string URL;
    //post的数据表单
    public WWWForm Pick;
    //post成功回调
    public Action<UnityWebRequest> TripCrowbar;
    //post失败回调
    public Action TripAsia;
    public PryYarnTripPoison(string url,WWWForm  form,Action<UnityWebRequest> success,Action fail)
    {
        URL = url;
        Pick = form;
        TripCrowbar = success;
        TripAsia = fail;
    }
}
