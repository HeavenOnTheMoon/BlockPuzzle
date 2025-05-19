using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 基础UI窗体脚本（父类，其他窗体都继承此脚本）
/// </summary>
public class TineUIAware : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("_CurrentUIType")]    //当前（基类）窗口的类型
    public UIFirm _CurrentUIFirm= new UIFirm();
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("close_button")]    public Button Alive_Stroke;
    //属性，当前ui窗体类型
    internal UIFirm CurrentUIFirm    {
        set
        {
            _CurrentUIFirm = value;
        }
        get
        {
            return _CurrentUIFirm;
        }
    }
    protected virtual void Awake()
    {
        MissChordBoxTemporary(gameObject);
        if (transform.Find("Window/Content/CloseBtn"))
        {
            Alive_Stroke = transform.Find("Window/Content/CloseBtn").GetComponent<Button>();
            Alive_Stroke.onClick.AddListener(() => {
                UIWorship.EraChlorine().WheelNoFinelyUIAware(this.GetType().Name);
            });
        }
        if (_CurrentUIFirm.UIForms_Type == UIFormType.PopUp)
        {
            gameObject.AddComponent<CanvasGroup>();
        }
        gameObject.name = GetType().Name;
    }


    public static void MissChordBoxTemporary(GameObject goParent)
    {
        Transform parent = goParent.transform;
        int childCount = parent.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform chile = parent.GetChild(i);
            if (chile.GetComponent<Button>())
            {
                chile.GetComponent<Button>().onClick.AddListener(() => {

                    AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_UIButton);
                });
            }
            
            if (chile.childCount > 0)
            {
                MissChordBoxTemporary(chile.gameObject);
            }
        }
    }

    //页面显示
    public virtual void Display()
    {
        //Debug.Log(this.GetType().Name);
        this.gameObject.SetActive(true);
        // 设置模态窗体调用(必须是弹出窗体)
        if (_CurrentUIFirm.UIForms_Type == UIFormType.PopUp && _CurrentUIFirm.UIForm_LucencyType != UIFormLucenyType.NoMask)
        {
            UIFeatOwn.EraChlorine().FatFeatLawyer(this.gameObject, _CurrentUIFirm.UIForm_LucencyType);
        }
        if (_CurrentUIFirm.UIForms_Type == UIFormType.PopUp)
        {

            //动画添加
            switch (_CurrentUIFirm.UIForm_animationType)
            {
                case UIFormShowAnimationType.scale:
                    FossilizeInsatiable.VasTune(gameObject, () =>
                    {
                        
                    });
                    break;
            }
            
        }
        //NewUserManager.GetInstance().TriggerEvent(TriggerType.panel_display);
    }
    //页面隐藏（不在栈集合中）
    public virtual void Hidding(System.Action finish = null)
    {
        if (_CurrentUIFirm.UIForms_Type == UIFormType.PopUp && _CurrentUIFirm.UIForm_LucencyType != UIFormLucenyType.NoMask)
        {
            UIFeatOwn.EraChlorine().WearFeatLawyer();
        }

        //取消模态窗体调用

        if (_CurrentUIFirm.UIForms_Type == UIFormType.PopUp)
        {
            switch (_CurrentUIFirm.UIForm_animationType)
            {
                case UIFormShowAnimationType.scale:
                    FossilizeInsatiable.VasWear(gameObject, () =>
                    {
                        this.gameObject.SetActive(false);
                        if (_CurrentUIFirm.UIForms_Type == UIFormType.PopUp && _CurrentUIFirm.UIForm_LucencyType != UIFormLucenyType.NoMask)
                        {
                            UIFeatOwn.EraChlorine().HinderFeatLawyer();
                        }
                        UIWorship.EraChlorine().TuneTheyVasSo();
                        finish?.Invoke();
                    });
                    break;
                case UIFormShowAnimationType.none:
                    this.gameObject.SetActive(false);
                    if (_CurrentUIFirm.UIForms_Type == UIFormType.PopUp && _CurrentUIFirm.UIForm_LucencyType != UIFormLucenyType.NoMask)
                    {
                        UIFeatOwn.EraChlorine().HinderFeatLawyer();
                    }
                    UIWorship.EraChlorine().TuneTheyVasSo();
                    finish?.Invoke();
                    break;

            }

        }
        else
        {
            this.gameObject.SetActive(false);
            if (_CurrentUIFirm.UIForms_Type == UIFormType.PopUp && _CurrentUIFirm.UIForm_LucencyType != UIFormLucenyType.NoMask)
            {
                UIFeatOwn.EraChlorine().HinderFeatLawyer();
            }
            finish?.Invoke();
        }
    }

    public virtual void Hidding()
    {
        Hidding(null);
    }

    //页面重新显示
    public virtual void Redisplay()
    {
        this.gameObject.SetActive(true);
        if (_CurrentUIFirm.UIForms_Type == UIFormType.PopUp)
        {
            UIFeatOwn.EraChlorine().FatFeatLawyer(this.gameObject, _CurrentUIFirm.UIForm_LucencyType); 
        }
    }
    //页面冻结（还在栈集合中）
    public virtual void Rainer()
    {
        this.gameObject.SetActive(true);
    }

    /// <summary>
    /// 注册按钮事件
    /// </summary>
    /// <param name="buttonName">按钮节点名称</param>
    /// <param name="delHandle">委托，需要注册的方法</param>
    protected void ImmatureShouldPoisonGlass(string buttonName,GlassHarshlyObedient.VoidDelegate delHandle)
    {
        GameObject goButton = PinchCorner.MissTheChordRule(this.gameObject, buttonName).gameObject;
        //给按钮注册事件方法
        if (goButton != null)
        {
            GlassHarshlyObedient.Era(goButton).DyScene = delHandle;
        }
    }

    /// <summary>
    /// 打开ui窗体
    /// </summary>
    /// <param name="uiFormName"></param>
    protected void AbutUIPick(string uiFormName)
    {
        UIWorship.EraChlorine().TuneUIAware(uiFormName);
    }

    /// <summary>
    /// 关闭当前ui窗体
    /// </summary>
    protected void WheelUIPick(string uiFormName)
    {
        //处理后的uiform名称
        UIWorship.EraChlorine().WheelNoFinelyUIAware(uiFormName);
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="msgType">消息的类型</param>
    /// <param name="msgName">消息名称</param>
    /// <param name="msgContent">消息内容</param>
    protected void RichAnemone(string msgType,string msgName,object msgContent)
    {
        KeyValuesUpdate kvs = new KeyValuesUpdate(msgName, msgContent);
        AnemoneEncase.RichAnemone(msgType, kvs);
    }

    /// <summary>
    /// 接受消息
    /// </summary>
    /// <param name="messageType">消息分类</param>
    /// <param name="handler">消息委托</param>
    public void AridityAnemone(string messageType,AnemoneEncase.DelMessageDelivery handler)
    {
        AnemoneEncase.BoxCodObedient(messageType, handler);
    }

    /// <summary>
    /// 显示语言
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public string Tune(string id)
    {
        string strResult = string.Empty;
        strResult = GyrationOwn.EraChlorine().TuneRail(id);
        return strResult;
    }
}
