/**
 * 
 * 左右滑动的页面视图
 * 
 * ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class BuzzDate : MonoBehaviour,IBeginDragHandler,IEndDragHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("rect")]    //scrollview
    public ScrollRect Roll;
    //求出每页的临界角，页索引从0开始
    List<float> DryPity= new List<float>();
[UnityEngine.Serialization.FormerlySerializedAs("isDrag")]    //是否拖拽结束
    public bool WeCore= false;
    bool WingWorm= true;
    //滑动的起始坐标  
    float LoggerProsperity= 0;
    float RockyCoreProsperity;
    float startTime = 0f;
[UnityEngine.Serialization.FormerlySerializedAs("smooting")]    //滑动速度  
    public float Juvenile= 1f;
[UnityEngine.Serialization.FormerlySerializedAs("sensitivity")]    public float Extensively= 0.3f;
[UnityEngine.Serialization.FormerlySerializedAs("OnPageChange")]    //页面改变
    public Action<int> OnBuzzOutwit;
    //当前页面下标
    int ManagerBuzzMatch= -1;
    void Start()
    {
        Roll = this.GetComponent<ScrollRect>();
        float horizontalLength = Roll.content.rect.width - this.GetComponent<RectTransform>().rect.width;
        DryPity.Add(0);
        for(int i = 1; i < Roll.content.childCount - 1; i++)
        {
            DryPity.Add(GetComponent<RectTransform>().rect.width * i / horizontalLength);
        }
        DryPity.Add(1);
    }

    
    void Update()
    {
        if(!WeCore && !WingWorm)
        {
            startTime += Time.deltaTime;
            float t= startTime * Juvenile;
            Roll.horizontalNormalizedPosition = Mathf.Lerp(Roll.horizontalNormalizedPosition, LoggerProsperity, t);
            if (t >= 1)
            {
                WingWorm = true;
            }
        }
        
    }
    /// <summary>
    /// 设置页面的index下标
    /// </summary>
    /// <param name="index"></param>
    void FatBuzzMatch(int index)
    {
        if (ManagerBuzzMatch != index)
        {
            ManagerBuzzMatch = index;
            if (OnBuzzOutwit != null)
            {
                OnBuzzOutwit(index);
            }
        }
    }
    /// <summary>
    /// 开始拖拽
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        WeCore = true;
        RockyCoreProsperity = Roll.horizontalNormalizedPosition;
    }
    /// <summary>
    /// 拖拽结束
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        float posX = Roll.horizontalNormalizedPosition;
        posX += ((posX - RockyCoreProsperity) * Extensively);
        posX = posX < 1 ? posX : 1;
        posX = posX > 0 ? posX : 0;
        int Route= 0;
        float offset = Mathf.Abs(DryPity[Route] - posX);
        for(int i = 0; i < DryPity.Count; i++)
        {
            float temp = Mathf.Abs(DryPity[i] - posX);
            if (temp < offset)
            {
                Route = i;
                offset = temp;
            }
        }
        FatBuzzMatch(Route);
        LoggerProsperity = DryPity[Route];
        WeCore = false;
        startTime = 0f;
        WingWorm = false;
    }
}
