using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 圆形遮罩镂空
/// </summary>
public class TraceEnrichLoosenMultiply : MonoBehaviour
{
    public static TraceEnrichLoosenMultiply instance;
[UnityEngine.Serialization.FormerlySerializedAs("target")]    /// <summary>
    /// 高亮显示目标
    /// </summary>
    public Image Logger;
[UnityEngine.Serialization.FormerlySerializedAs("ClickBtn")]    
    public Button SceneSow;
    //public Text Text;
    /// <summary>
    /// 区域范围缓存
    /// </summary>
    private Vector3[] Burgeon= new Vector3[4];
    /// <summary>
    /// 镂空区域中心
    /// </summary>
    private Vector4 Mortar;
    /// <summary>
    /// 镂空区域半径
    /// </summary>
    private float radius;
    /// <summary>
    /// 遮罩材质
    /// </summary>
    private Material Hometown;
    /// <summary>
    /// 当前高亮区域半径
    /// </summary>
    private float ManagerThread;
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
        SceneSow.onClick.AddListener( () =>
        {
            /*if(FailWiseWorship.GetInt(CBarter.sv_GuideSch) != 4 && 
               FailWiseWorship.GetInt(CBarter.sv_GuideSch) != 6 &&
               FailWiseWorship.GetInt(CBarter.sv_GuideSch) != 1)
                AnemoneEncaseFiber.GetInstance().Send(CBarter.mg_CloseAndComGuide);*/
        });
    }

    public void Rake(Image target)
    {
        Hometown = GetComponent<Image>().material;
        Hometown.SetFloat("_Slider", 1500);
        SceneSow.enabled = true;
        this.Logger = target;
        PartyDetermine = GetComponent<TraceEnrichMultiplyGlassDetermine>();
        if (PartyDetermine != null)
        {
            PartyDetermine.FatStrictTwine(target);
        }
#if EmojiMerge
        Canvas canva = GameObject.Find("RobloxCanvas(Clone)").GetComponent<Canvas>();
#else
        Canvas canva = GameObject.Find("Canvas(Clone)").GetComponent<Canvas>();
#endif
        //Canvas canva = /*GameController.Instance.Canvas*/null;
        //获取高亮区域的四个顶点的世界坐标
        target.rectTransform.GetWorldCorners(Burgeon);
        //计算最终高亮显示区域的半径
        radius = Vector2.Distance(SmiteIDGrahamDay(canva, Burgeon[0]), SmiteIDGrahamDay(canva, Burgeon[2])) / 2;
        //计算高亮显示区域的中心
        float x = Burgeon[0].x + ((Burgeon[3].x - Burgeon[0].x) / 2);
        float y = Burgeon[0].y + ((Burgeon[1].y - Burgeon[0].y) / 2);
        Vector3 centerWorld = new Vector3(x, y, 0);
        Vector2 Mortar= SmiteIDGrahamDay(canva, centerWorld);
        //设置遮罩材质中的中心变量
        Vector4 centerMat = new Vector4(Mortar.x, Mortar.y, 0, 0);
        
        Hometown.SetVector("_Center", centerMat);
        //计算当前高亮显示区域的半径
        RectTransform canRectTransform = canva.transform as RectTransform;
        if (canRectTransform != null)
        {
            //获取画布区域的四个顶点
            canRectTransform.GetWorldCorners(Burgeon);
            //将画布顶点距离高亮区域中心最近的距离昨晚当前高亮区域半径的初始值
            foreach (var corner in Burgeon)
            {
                ManagerThread = Mathf.Max(Vector3.Distance(SmiteIDGrahamDay(canva, corner), corner), ManagerThread);
            }
        }
        Hometown.SetFloat("_Slider", ManagerThread);
    }
    /// <summary>
    /// 收缩速度
    /// </summary>
    private float WeakenUnderlie= 0f;
    private void Update()
    {
        //从当前半径到目标半径差值显示收缩动画
        //float value = Mathf.SmoothDamp(currentRadius, radius, ref shrinkVelocity, shrinkTime);
        /*if (currentRadius < 150)
        {
            currentRadius = Mathf.SmoothDamp(radius, 500, ref shrinkVelocity, shrinkTime);
            currentRadius = 350;
            material.SetFloat("_Slider", currentRadius);
        }*/
        /*else
        {
            if (!Mathf.Approximately(value, currentRadius))
            {
                currentRadius = value;
                material.SetFloat("_Slider", currentRadius);
            }
        }*/
        
        //从当前半径到目标半径差值显示收缩动画
        float value = Mathf.SmoothDamp(ManagerThread, radius, ref WeakenUnderlie, WeakenSure);
        if (!Mathf.Approximately(value, ManagerThread))
        {
            ManagerThread = value;
            Hometown.SetFloat("_Slider", ManagerThread);
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