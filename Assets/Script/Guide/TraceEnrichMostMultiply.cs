using System;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 矩形遮罩镂空
/// </summary>
public class TraceEnrichMostMultiply : MonoBehaviour
{
    public static TraceEnrichMostMultiply instance;
[UnityEngine.Serialization.FormerlySerializedAs("target")]    /// <summary>
    /// 高亮显示目标
    /// </summary>
    public Image Logger;
[UnityEngine.Serialization.FormerlySerializedAs("ClickBtn")]
    public Button SceneSow;
[UnityEngine.Serialization.FormerlySerializedAs("Text")]    public Text Rail;
    /// <summary>
    /// 区域范围缓存
    /// </summary>
    private Vector3[] Burgeon= new Vector3[4];
    /// <summary>
    /// 镂空区域中心
    /// </summary>
    private Vector4 Mortar;
    /// <summary>
    /// 最终的偏移x
    /// </summary>
    private float LoggerInviteX= 0;
    /// <summary>
    /// 最终的偏移y
    /// </summary>
    private float LoggerInviteY= 0;
    /// <summary>
    /// 遮罩材质
    /// </summary>
    private Material Hometown;
    /// <summary>
    /// 当前的偏移x
    /// </summary>
    private float ManagerInviteX= 0f;
    /// <summary>
    /// 当前的偏移y
    /// </summary>
    private float ManagerInviteY= 0f;
    /// <summary>
    /// 高亮区域缩放的动画时间
    /// </summary>
    private float WeakenSure= 0.3f;
    /// <summary>
    /// 事件渗透组件
    /// </summary>
    private TraceEnrichMultiplyGlassDetermine PartyDetermine;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        SceneSow.onClick.AddListener(() =>
        {
            /*if (FailWiseWorship.GetInt(CBarter.sv_GuideSch) == 5)
            {
                AnemoneEncaseFiber.GetInstance().Send(CBarter.mg_CloseAndComGuide);
                FailWiseWorship.SetInt(CBarter.sv_GuideSch, 6);
                UIWorship.GetInstance().ShowUIForms("SolidDelta");
            }*/
        });
    }
[UnityEngine.Serialization.FormerlySerializedAs("Currentindex")]
    public int Infrequently;
    public void Rake(Image target, int index = -1)
    {
        SceneSow.enabled = true;
        Hometown = GetComponent<Image>().material;
        Hometown.SetFloat("_Slider", 1500);
        this.Logger = target;
        
        /*eventPenetrate = GetComponent<TraceEnrichMultiplyGlassDetermine>();
        if (eventPenetrate != null)
        {
            eventPenetrate.SetTargetImage(target);
        }*/

#if EmojiMerge
        Canvas canvas = GameObject.Find("RobloxCanvas(Clone)").GetComponent<Canvas>();
#else
        Canvas canvas = GameObject.Find("Canvas(Clone)").GetComponent<Canvas>();
#endif
        
        //Canvas canvas = /*GameController.Instance.Canvas*/null;
        //获取高亮区域的四个顶点的世界坐标
        target.rectTransform.GetWorldCorners(Burgeon);
        //计算高亮显示区域在画布中的范围
        LoggerInviteX = Vector2.Distance(SmiteIDGrahamDay(canvas, Burgeon[0]), SmiteIDGrahamDay(canvas, Burgeon[3])) / 2f;
        LoggerInviteY = Vector2.Distance(SmiteIDGrahamDay(canvas, Burgeon[0]), SmiteIDGrahamDay(canvas, Burgeon[1])) / 2f;
        //计算高亮显示区域的中心
        float x = Burgeon[0].x + ((Burgeon[3].x - Burgeon[0].x) / 2);
        float y = Burgeon[0].y + ((Burgeon[1].y - Burgeon[0].y) / 2);
        Vector3 centerWorld = new Vector3(x, y, 0);
        Vector2 Mortar= SmiteIDGrahamDay(canvas, centerWorld);
        //设置遮罩材质中的中心变量
        Vector4 centerMat = new Vector4(Mortar.x, Mortar.y, 0, 0);
        
        Hometown.SetVector("_Center", centerMat);
        //计算当前高亮显示区域的半径
        RectTransform canRectTransform = canvas.transform as RectTransform;
        if (canRectTransform != null)
        {
            //获取画布区域的四个顶点
            canRectTransform.GetWorldCorners(Burgeon);
            //计算偏移初始值
            for (int i = 0; i < Burgeon.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ManagerInviteX = Mathf.Max(Vector3.Distance(SmiteIDGrahamDay(canvas, Burgeon[i]), Mortar), ManagerInviteX);
                }
                else
                {
                    ManagerInviteY = Mathf.Max(Vector3.Distance(SmiteIDGrahamDay(canvas, Burgeon[i]), Mortar), ManagerInviteY);
                }
            }
        }
        //设置遮罩材质中当前偏移的变量
        Hometown.SetFloat("_SliderX", ManagerInviteX);
        Hometown.SetFloat("_SliderY", ManagerInviteY);
    }
    /// <summary>
    /// 收缩速度
    /// </summary>
    private float WeakenUnderlieX= 0f;
    private float WeakenUnderlieY= 0f;
    private void Update()
    {
        //从当前偏移量到目标偏移量差值显示收缩动画
        float valueX = Mathf.SmoothDamp(ManagerInviteX, LoggerInviteX, ref WeakenUnderlieX, WeakenSure);
        float valueY = Mathf.SmoothDamp(ManagerInviteY, LoggerInviteY, ref WeakenUnderlieY, WeakenSure);
        if (!Mathf.Approximately(valueX, ManagerInviteX))
        {
            ManagerInviteX = valueX;
            Hometown.SetFloat("_SliderX", ManagerInviteX);
        }
        if (!Mathf.Approximately(valueY, ManagerInviteY))
        {
            ManagerInviteY = valueY;
            Hometown.SetFloat("_SliderY", ManagerInviteY);
        }
        
        
    }

    /// <summary>
    /// 世界坐标转换为画布坐标
    /// </summary>
    /// <param name="canvas">画布</param>
    /// <param name="world">世界坐标</param>
    /// <returns></returns>
    private Vector2 SmiteIDGrahamDay(Canvas canvas, Vector3 world)
    {
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, world, canvas.GetComponent<Camera>(), out position);
        return position;
    }
}
