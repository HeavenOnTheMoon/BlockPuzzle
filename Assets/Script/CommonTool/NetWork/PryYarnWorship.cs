/**
 * 
 * 网络请求管理器
 * 
 * ***/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PryYarnWorship : CoatOutnumber<PryYarnWorship>
{
    //get请求列表
    private List<PryYarnEraPoison> PryYarnEraPity;
    //post请求列表
    private List<PryYarnTripPoison> PryYarnTripPity;
    public PryYarnWorship()
    {
        //初始化
        PryYarnEraPity = new List<PryYarnEraPoison>();
        PryYarnTripPity = new List<PryYarnTripPoison>();
    }

    /// <summary>
    /// 获取当前Get请求列表中请求的个数
    /// </summary>
    public int EraPryYarnEraPityCajun{
        get { return PryYarnEraPity.Count; }
    }

    /// <summary>
    /// 获取当前Post请求列表中请求的个数
    /// </summary>
    public int EraPryYarnTripPityCajun    {
        get { return PryYarnTripPity.Count; }
    }

    /// <summary>
    /// Get请求
    /// </summary>
    /// <param name="url">Get请求的URL</param>
    /// <param name="success">Get请求成功的回调</param>
    /// <param name="fail">Get请求失败的回调</param>
    public void ThanEra(string url,Action<UnityWebRequest> success,Action fail)
    {
        if (string.IsNullOrEmpty(url))
        {
            Debug.Log("HttpGet请求URL地址不能为空");
            return;
        }
        PryYarnEraPoison o = new PryYarnEraPoison(url, success, fail);
        //添加到管理列表中
        PryYarnEraPity.Add(o);
        //开始请求
       StartCoroutine("Era", o);
    }

    /// <summary>
    /// Post请求
    /// </summary>
    /// <param name="url">Post请求的URL</param>
    /// <param name="form">Post请求的表单数据</param>
    /// <param name="success">Post请求成功的回调</param>
    /// <param name="fail">Post请求失败的回调</param>
    public void ThanTrip(string url,WWWForm form, Action<UnityWebRequest> success,Action fail)
    {
        if (string.IsNullOrEmpty(url))
        {
            Debug.Log("HttpPost请求URL地址不能为空");
            return;
        }
        PryYarnTripPoison o = new PryYarnTripPoison(url, form, success, fail);
        //添加到post请求管理列表中
        PryYarnTripPity.Add(o);
        //开始请求
        StartCoroutine("Trip", o);
    }

    /// <summary>
    /// Get请求的协程
    /// </summary>
    /// <param name="obj">Get请求对象</param>
    /// <returns></returns>
    IEnumerator Era(PryYarnEraPoison obj)
    {
        UnityWebRequest webRequest = UnityWebRequest.Get(obj.Eat);
        webRequest.SendWebRequest();
        while (!webRequest.isDone)
        {
            yield return 1;
        }
        if (webRequest.isDone)
        {
            //从管理列表中移除
            if (PryYarnEraPity.Contains(obj))
            {
                PryYarnEraPity.Remove(obj);
            }
        }
        //yield return webRequest.SendWebRequest();
        //异常处理,请求失败
        if (webRequest.isHttpError || webRequest.isNetworkError)
        {
            Debug.Log("请求"+ obj.Eat+"失败，错误："+webRequest.error);
            obj.EraAsia();
        }else
        {
            //Debug.Log(webRequest.downloadHandler.text);
            obj.EraCrowbar(webRequest);
        }      
        //终止本次协程
        yield break;
    }



    /// <summary>
    /// Post协程
    /// </summary>
    /// <returns></returns>
    IEnumerator Trip(PryYarnTripPoison obj)
    {
        //WWWForm form = new WWWForm();
        ////键值对
        //form.AddField("key", "value");
        //form.AddField("name", "mafanwei");
        //form.AddField("blog", "qwe25878");

        UnityWebRequest webRequest = UnityWebRequest.Post(obj.URL, obj.Pick);

        yield return webRequest.SendWebRequest();
        //异常处理
        if (webRequest.isHttpError || webRequest.isNetworkError)
        {
            Debug.Log("Post请求"+obj.URL+"失败，错误："+webRequest.error);
            obj.TripAsia();
        } else
        {
            obj.TripCrowbar(webRequest);
            //Debug.Log(webRequest.downloadHandler.text);
        }

        //从管理列表中移除
        if (PryYarnTripPity.Contains(obj))
        {
            PryYarnTripPity.Remove(obj);
        }
        //终止本次协程
        yield break;
    }
}
