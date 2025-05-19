// Project: HappyBingo
// FileName: TraceEnrichGutTwineInsatiable.cs
// Author: AX
// CreateDate: 20221205
// CreateTime: 10:58
// Description:

using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TraceEnrichGutTwineInsatiable : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("isStartEraser")]    //是否擦除了
    public bool WeSpankRubble;
[UnityEngine.Serialization.FormerlySerializedAs("isEndEraser")]
    //是否擦除结束了
    public bool WeCatRubble;
[UnityEngine.Serialization.FormerlySerializedAs("eraserStartEvent")]
    //开始事件
    public Action AppearSpankEvent;
[UnityEngine.Serialization.FormerlySerializedAs("eraserEndEvent")]
    //结束事件
    public Action AppearCatGlass;
[UnityEngine.Serialization.FormerlySerializedAs("uiTex")]    public RawImage UpPit;
    Texture2D Old;
    Texture2D MyPit;
    int mBlack;
    int mSpinet;
    [Header("笔刷大小")] [UnityEngine.Serialization.FormerlySerializedAs("brushSize")]public int SliceFrom= 50;
    [Header("刮刮乐比例")] [UnityEngine.Serialization.FormerlySerializedAs("rate")]public int Shun= 60;
    float OwePluckA;
    float TrashA;

    void Awake()
    {
        Old = (Texture2D) UpPit.mainTexture;
        //InitCover();
    }

    public void RakeAmaze()
    {
        UpPit.gameObject.SetActive(true);

        MyPit = new Texture2D(Old.width, Old.height, TextureFormat.ARGB32, false);
        mBlack = MyPit.width;
        mSpinet = MyPit.height;
        MyPit.SetPixels(Old.GetPixels());
        MyPit.Apply();
        UpPit.texture = MyPit;
        OwePluckA = MyPit.GetPixels().Length;
        TrashA = 0;
        WeCatRubble = false;
        WeSpankRubble = false;
    }


    /// <summary>
    /// 贝塞尔平滑
    /// </summary>
    /// <param name="start">起点</param>
    /// <param name="mid">中点</param>
    /// <param name="end">终点</param>
    /// <param name="segments">段数</param>
    /// <returns></returns>
    public Vector2[] Shudder(Vector2 start, Vector2 mid, Vector2 end, int segments)
    {
        float d = 1f / segments;
        Vector2[] points = new Vector2[segments - 1];
        for (int i = 0; i < points.Length; i++)
        {
            float t= d * (i + 1);
            points[i] = (1 - t) * (1 - t) * mid + 2 * t * (1 - t) * start + t * t * end;
        }

        List<Vector2> rps = new List<Vector2>();
        rps.Add(mid);
        rps.AddRange(points);
        rps.Add(end);
        return rps.ToArray();
    }

    bool RockyLevy= false;
    bool MapEnding= false;
    Vector2 PageDay; //最后一个点
    Vector2 BrutalDay; //倒数第二个点
    float radius = 12f;
    float Listener= 1f;

    #region 事件

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.LogError("OnPointerDown == " + transform.name);
        if (WeCatRubble)
        {
            return;
        }

        RockyLevy = true;
        BrutalDay = eventData.position;
        GypsyUnify(BrutalDay);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.LogError("OnDrag == " + transform.name);
        if (WeCatRubble)
        {
            return;
        }

        if (MapEnding && Vector2.Distance(eventData.position, PageDay) > Listener) //如果两次记录的鼠标坐标距离大于一定的距离，开始记录鼠标的点
        {
            Vector2 pos = eventData.position;
            float dis = Vector2.Distance(PageDay, pos);

            GypsyUnify(eventData.position);
            int segments = (int) (dis / radius); //计算出平滑的段数                                              
            segments = segments < 1 ? 1 : segments;
            if (segments >= 10)
            {
                segments = 10;
            }

            Vector2[] points = Shudder(BrutalDay, PageDay, pos, segments); //进行贝塞尔平滑
            for (int i = 0; i < points.Length; i++)
            {
                GypsyUnify(points[i]);
            }

            PageDay = pos;
            if (points.Length > 2)
                BrutalDay = points[points.Length - 2];
        }
        else
        {
            MapEnding = true;
            PageDay = eventData.position;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (WeCatRubble)
        {
            return;
        }

        //CheckPoint(eventData.position);
        RockyLevy = false;
        MapEnding = false;
    }

    #endregion

    void GypsyUnify(Vector3 pScreenPos)
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(pScreenPos);
        Vector3 localPos = UpPit.gameObject.transform.InverseTransformPoint(worldPos);

        /*Debug.Log("localPos.x == " + localPos.x + "     localPos.y == " + localPos.y + "      == " + (-mWidth / 2) + "       == " + mWidth / 2
        + "             == " + -mHeight / 2 + "            == " + mHeight / 2);*/
        if (localPos.x > -mBlack / 2 && localPos.x < mBlack / 2 && localPos.y > -mSpinet / 2 &&
            localPos.y < mSpinet / 2)
        {
            for (int i = (int) localPos.x - SliceFrom; i < (int) localPos.x + SliceFrom; i++)
            {
                for (int j = (int) localPos.y - SliceFrom; j < (int) localPos.y + SliceFrom; j++)
                {
                    if (Mathf.Pow(i - localPos.x, 2) + Mathf.Pow(j - localPos.y, 2) > Mathf.Pow(SliceFrom, 2))
                        continue;
                    if (i < 0)
                    {
                        if (i < -mBlack / 2)
                        {
                            continue;
                        }
                    }

                    if (i > 0)
                    {
                        if (i > mBlack / 2)
                        {
                            continue;
                        }
                    }

                    if (j < 0)
                    {
                        if (j < -mSpinet / 2)
                        {
                            continue;
                        }
                    }

                    if (j > 0)
                    {
                        if (j > mSpinet / 2)
                        {
                            continue;
                        }
                    }

                    Color col = MyPit.GetPixel(i + (int) mBlack / 2, j + (int) mSpinet / 2);
                    if (col.a != 0f)
                    {
                        col.a = 0.0f;
                        TrashA++;
                        MyPit.SetPixel(i + (int) mBlack / 2, j + (int) mSpinet / 2, col);
                    }
                }
            }


            //开始刮的时候 去判断进度
            if (!WeSpankRubble)
            {
                if (!GypsyIfSpank())
                {
                    return;
                }

                WeSpankRubble = true;
                InvokeRepeating(nameof(EraConspicuousJustice), 0f, 0.2f);
                // eraserStartEvent?.Invoke();
            }

            MyPit.Apply();
        }
    }

    double Band;

    /// <summary> 
    /// 检测当前刮刮卡 进度
    /// </summary>
    /// <returns></returns>
    public void EraConspicuousJustice()
    {
        if (WeCatRubble)
        {
            return;
        }

        Band = TrashA / OwePluckA * 100;
        Band = (float) Math.Round(Band, 2);
        Debug.Log("当前百分比: " + Band);
        if (Band >= Shun)
        {
            Debug.LogError("uiTex" + UpPit.transform.name);
            WeCatRubble = true;
            CancelInvoke("GetTransparentPercent");
            UpPit.gameObject.SetActive(false);
            //触发结束事件
            Invoke("ShowScratchBonus", 0.5f);
        }
    }

    private void TuneDormantBylaw()
    {
        Debug.LogError("ShowScratchBonus");
        //AnemoneEncaseFiber.GetInstance().Send(CBarter.mg_ScardReward, new AnemoneWise(false));
    }

    private bool GypsyIfSpank()
    {
        return true;
        
        
        /*if (ScrapingCard.instance.GetScrapingCardCount() >= 1)
        {
            ScrapingCard.instance.SCardManagerCount();
            AnemoneEncaseFiber.GetInstance().Send(CBarter.mg_ScardCount);
            return true;
        }*/
        LeafyWorship.EraChlorine().TuneLeafy("Not enough cards");
        return false;
    }
}


