/*
 *     主题： 事件触发监听      
 *    Description: 
 *           功能： 实现对于任何对象的监听处理。
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GlassHarshlyObedient : UnityEngine.EventSystems.EventTrigger
{
    public delegate void VoidDelegate(GameObject go);
    public VoidDelegate DyScene;
    public VoidDelegate DyKier;
    public VoidDelegate DyFence;
    public VoidDelegate DyFlat;
    public VoidDelegate DyUp;
    public VoidDelegate DyZigzag;
    public VoidDelegate DyWoodenZigzag;

    /// <summary>
    /// 得到监听器组件
    /// </summary>
    /// <param name="go">监听的游戏对象</param>
    /// <returns></returns>
    public static GlassHarshlyObedient Era(GameObject go)
    {
        GlassHarshlyObedient listener = go.GetComponent<GlassHarshlyObedient>();
        if (listener == null)
        {
            listener = go.AddComponent<GlassHarshlyObedient>();
        }
        return listener;
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        if (DyScene != null)
        {
            DyScene(gameObject);
        }
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (DyKier != null)
        {
            DyKier(gameObject);
        }
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (DyFence != null)
        {
            DyFence(gameObject);
        }
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        if (DyFlat != null)
        {
            DyFlat(gameObject);
        }
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        if (DyUp != null)
        {
            DyUp(gameObject);
        }
    }
    public override void OnSelect(BaseEventData eventData)
    {
        if (DyZigzag != null)
        {
            DyZigzag(gameObject);
        }
    }
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        if (DyWoodenZigzag != null)
        {
            DyWoodenZigzag(gameObject);
        }
    }
}
