/*
        主题： UI遮罩管理器  

        “弹出窗体”往往因为需要玩家优先处理弹出小窗体，则要求玩家不能(无法)点击“父窗体”，这种窗体就是典型的“模态窗体”
  5  *    Description: 
  6  *           功能： 负责“弹出窗体”模态显示实现
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIFeatOwn : MonoBehaviour
{
    private static UIFeatOwn _Chlorine= null;
    //ui根节点对象
    private GameObject _GoGrahamPlum= null;
    //ui脚本节点对象
    private Transform _YouUIFoghornRule= null;
    //顶层面板
    private GameObject _ItIDDelta;
    //遮罩面板
    private GameObject _ItFeatDelta;
    //ui摄像机
    private Camera _UIBarely;
    //ui摄像机原始的层深
    private float _LifetimeUIBarelyPilot;
    //获取实例
    public static UIFeatOwn EraChlorine()
    {
        if (_Chlorine == null)
        {
            _Chlorine = new GameObject("_UIMaskMgr").AddComponent<UIFeatOwn>();
        }
        return _Chlorine;
    }
    private void Awake()
    {
        _GoGrahamPlum = GameObject.FindGameObjectWithTag(KeyUnlike.SYS_TAG_CANVAS);
        _YouUIFoghornRule = PinchCorner.MissTheChordRule(_GoGrahamPlum, KeyUnlike.SYS_SCRIPTMANAGER_NODE);
        //把脚本实例，座位脚本节点对象的子节点
        PinchCorner.BoxChordRuleIDInformRule(_YouUIFoghornRule, this.gameObject.transform);
        //获取顶层面板，遮罩面板
        _ItIDDelta = _GoGrahamPlum;
        _ItFeatDelta = PinchCorner.MissTheChordRule(_GoGrahamPlum, "_UIMaskPanel").gameObject;
        //得到uicamera摄像机原始的层深
        _UIBarely = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();
        if (_UIBarely != null)
        {
            //得到ui相机原始的层深
            _LifetimeUIBarelyPilot = _UIBarely.depth;
        }
        else
        {
            Debug.Log("UI_Camera is Null!,Please Check!");
        }
    }

    /// <summary>
    /// 设置遮罩状态
    /// </summary>
    /// <param name="goDisplayUIForms">需要显示的ui窗体</param>
    /// <param name="lucenyType">显示透明度属性</param>
    public void FatFeatLawyer(GameObject goDisplayUIForms,UIFormLucenyType lucenyType = UIFormLucenyType.Lucency)
    {
        //顶层窗体下移
        _ItIDDelta.transform.SetAsLastSibling();
        switch (lucenyType)
        {
               //完全透明 不能穿透
            case UIFormLucenyType.Lucency:
                _ItFeatDelta.SetActive(true);
                Color newColor = new Color(255 / 255F, 255 / 255F, 255 / 255F, 0F / 255F);
                _ItFeatDelta.GetComponent<Image>().color = newColor;
                break;
                //半透明，不能穿透
            case UIFormLucenyType.Translucence:
                _ItFeatDelta.SetActive(true);
                Color newColor2 = new Color(0 / 255F, 0 / 255F, 0 / 255F, 220 / 255F);
                _ItFeatDelta.GetComponent<Image>().color = newColor2;
                AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_LawyerAbut);
                break;
                //低透明，不能穿透
            case UIFormLucenyType.ImPenetrable:
                _ItFeatDelta.SetActive(true);
                Color newColor3 = new Color(50 / 255F, 50 / 255F, 50 / 255F, 240F / 255F);
                _ItFeatDelta.GetComponent<Image>().color = newColor3;
                break;
                //可以穿透
            case UIFormLucenyType.Penetrable:
                if (_ItFeatDelta.activeInHierarchy)
                {
                    _ItFeatDelta.SetActive(false);
                }
                break;
            default:
                break;
        }
        //遮罩窗体下移
        _ItFeatDelta.transform.SetAsLastSibling();
        //显示的窗体下移
        goDisplayUIForms.transform.SetAsLastSibling();
        //增加当前ui摄像机的层深（保证当前摄像机为最前显示）
        if (_UIBarely != null)
        {
            _UIBarely.depth = _UIBarely.depth + 100;
        }
    }
    public void WearFeatLawyer()
    {
        if (UIWorship.EraChlorine().WildUIAware.Count > 0 || UIWorship.EraChlorine().EraEagerlyPickBlock().Count > 0)
        {
            return;
        }
        Color newColor3 = new Color(_ItFeatDelta.GetComponent<Image>().color.r, _ItFeatDelta.GetComponent<Image>().color.g, _ItFeatDelta.GetComponent<Image>().color.b,0);
        _ItFeatDelta.GetComponent<Image>().color = newColor3;
    }
    /// <summary>
    /// 取消遮罩状态
    /// </summary>
    public void HinderFeatLawyer()
    {
        if (UIWorship.EraChlorine().WildUIAware.Count > 0 || UIWorship.EraChlorine().EraEagerlyPickBlock().Count > 0)
        {
            return;
        }
        //顶层窗体上移
        _ItIDDelta.transform.SetAsFirstSibling();
        //禁用遮罩窗体
        if (_ItFeatDelta.activeInHierarchy)
        {
            _ItFeatDelta.SetActive(false);
            AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_LawyerWheel);
        }
        //恢复当前ui摄像机的层深
        if (_UIBarely != null)
        {
            _UIBarely.depth = _LifetimeUIBarelyPilot;
        }
    }
}
