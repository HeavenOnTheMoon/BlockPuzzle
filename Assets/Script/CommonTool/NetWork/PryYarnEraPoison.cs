/***
 * 
 * 网络请求的get对象
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class PryYarnEraPoison 
{
    //get的url
    public string Eat;
    //get成功的回调
    public Action<UnityWebRequest> EraCrowbar;
    //get失败的回调
    public Action EraAsia;
    public PryYarnEraPoison(string url,Action<UnityWebRequest> success,Action fail)
    {
        Eat = url;
        EraCrowbar = success;
        EraAsia = fail;
    }
   
}
