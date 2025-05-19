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

public class TraceEnrichGutPigTwineInsatiable : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("isStartEraser")]    //是否擦除了
    public bool WeSpankRubble;
[UnityEngine.Serialization.FormerlySerializedAs("isEndEraser")]
    //是否擦除结束了
    public bool WeCatRubble;
[UnityEngine.Serialization.FormerlySerializedAs("isStartEraserTwo")]    
    //是否擦除了
    public bool WeSpankRubblePig;
[UnityEngine.Serialization.FormerlySerializedAs("isEndEraserTwo")]
    //是否擦除结束了
    public bool WeCatRubblePig;
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
[UnityEngine.Serialization.FormerlySerializedAs("uiTexTwo")]    
    public RawImage UpPitPig;
    Texture2D OldPig;
    Texture2D ToPitPig;
    int mBlackPig;
    int mSpinetPig;
    [Header("笔刷大小")] [UnityEngine.Serialization.FormerlySerializedAs("brushSizeTwo")]public int SliceFromPig= 50;
    [Header("刮刮乐比例")] [UnityEngine.Serialization.FormerlySerializedAs("rateTwo")]public int ShunPig= 60;
    float OwePluckAPig;
    float TrashAPig;

    void Awake()
    {
        Old = (Texture2D) UpPit.mainTexture;
        OldPig = (Texture2D) UpPitPig.mainTexture;
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
        
        
        UpPitPig.gameObject.SetActive(true);

        ToPitPig = new Texture2D(OldPig.width, OldPig.height, TextureFormat.ARGB32, false);
        mBlackPig = ToPitPig.width;
        mSpinetPig = ToPitPig.height;
        ToPitPig.SetPixels(OldPig.GetPixels());
        ToPitPig.Apply();
        UpPitPig.texture = ToPitPig;
        OwePluckAPig = ToPitPig.GetPixels().Length;
        TrashAPig = 0;
        WeCatRubblePig = false;
        WeSpankRubblePig = false;
    }

    public void CannonAmaze()
    {
        UpPit.gameObject.SetActive(false);
        UpPitPig.gameObject.SetActive(false);
        WeCatRubble = true;
        WeCatRubblePig = true;
        Band = 100;
        BandPig = 100;
        TuneDormantBylaw();
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
    float Listener= 2f;
    
    bool RockyLevyPig= false;
    bool MapEndingPig= false;
    Vector2 PageDayPig; //最后一个点
    Vector2 BrutalDayPig; //倒数第二个点
    float OrangePig= 12f;
    float ListenerPig= 2f;

    #region 事件

    public void OnPointerDown(PointerEventData eventData)
    {
        /*Debug.LogError("OnPointerDown == " + transform.name);*/
        if (WeCatRubble && WeCatRubblePig)
        {
            return;
        }

        if (!WeCatRubble)
        {
            RockyLevy = true;
            
            BrutalDay = eventData.position;
            PageDay = BrutalDay;
            GypsyUnify(BrutalDay);
        }
        if (!WeCatRubblePig)
        {
            RockyLevyPig = true;
            BrutalDayPig = eventData.position;
            PageDayPig = BrutalDayPig;
            GypsyUnifyPig(BrutalDayPig);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        /*Debug.LogError("OnDrag == " + transform.name);*/
        if (WeCatRubble && WeCatRubblePig)
        {
            return;
        }

        if (!WeCatRubble)
        {
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
        
        if (!WeCatRubblePig)
        {
            if (MapEndingPig && Vector2.Distance(eventData.position, PageDayPig) > ListenerPig) //如果两次记录的鼠标坐标距离大于一定的距离，开始记录鼠标的点
            {
                Vector2 pos = eventData.position;
                float dis = Vector2.Distance(PageDayPig, pos);


                GypsyUnifyPig(eventData.position);
                int segments = (int) (dis / OrangePig); //计算出平滑的段数                                              
                segments = segments < 1 ? 1 : segments;
                if (segments >= 10)
                {
                    segments = 10;
                }

                Vector2[] points = Shudder(BrutalDayPig, PageDayPig, pos, segments); //进行贝塞尔平滑
                for (int i = 0; i < points.Length; i++)
                {
                    GypsyUnifyPig(points[i]);
                }

                PageDayPig = pos;
                if (points.Length > 2)
                    BrutalDayPig = points[points.Length - 2];
            }
            else
            {
                MapEndingPig = true;
                PageDayPig = eventData.position;
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (WeCatRubble && WeCatRubblePig)
        {
            return;
        }

        //CheckPoint(eventData.position);
        RockyLevy = false;
        MapEnding = false;
        RockyLevyPig = false;
        MapEndingPig = false;
    }

    #endregion
    void GypsyUnifyPig(Vector3 pScreenPos)
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(pScreenPos);
        Vector3 localPos = UpPitPig.gameObject.transform.InverseTransformPoint(worldPos);
        
        if (localPos.x > -mBlackPig / 2 && localPos.x < mBlackPig / 2 && localPos.y > -mSpinetPig / 2 &&
            localPos.y < mSpinetPig / 2)
        {
            /*Debug.Log("localPos.x222222222222 == " + localPos.x + "     localPos.y == " + localPos.y + "      == " + (-mWidthTwo / 2) + "       == " + mWidthTwo / 2
                      + "             == " + -mHeightTwo / 2 + "            == " + mHeightTwo / 2);*/
            for (int i = (int) localPos.x - SliceFromPig; i < (int) localPos.x + SliceFromPig; i++)
            {
                for (int j = (int) localPos.y - SliceFromPig; j < (int) localPos.y + SliceFromPig; j++)
                {
                    if (Mathf.Pow(i - localPos.x, 2) + Mathf.Pow(j - localPos.y, 2) > Mathf.Pow(SliceFromPig, 2))
                        continue;
                    if (i < 0)
                    {
                        if (i < -mBlackPig / 2)
                        {
                            continue;
                        }
                    }

                    if (i > 0)
                    {
                        if (i > mBlackPig / 2)
                        {
                            continue;
                        }
                    }

                    if (j < 0)
                    {
                        if (j < -mSpinetPig / 2)
                        {
                            continue;
                        }
                    }

                    if (j > 0)
                    {
                        if (j > mSpinetPig / 2)
                        {
                            continue;
                        }
                    }

                    Color col = ToPitPig.GetPixel(i + (int) mBlackPig / 2, j + (int) mSpinetPig / 2);
                    if (col.a != 0f)
                    {
                        col.a = 0.0f;
                        TrashAPig++;
                        ToPitPig.SetPixel(i + (int) mBlackPig / 2, j + (int) mSpinetPig / 2, col);
                    }
                }
            }


            //开始刮的时候 去判断进度
            if (!WeSpankRubblePig)
            {
                /*if (!CheckIfStart())
                {
                    return;
                }*/

                WeSpankRubblePig = true;
                InvokeRepeating(nameof(EraConspicuousJusticePig), 0f, 0.2f);
                // eraserStartEvent?.Invoke();
            }

            ToPitPig.Apply();
        }
    }
    void GypsyUnify(Vector3 pScreenPos)
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(pScreenPos);
        Vector3 localPos = UpPit.gameObject.transform.InverseTransformPoint(worldPos);

        
        if (localPos.x > -mBlack / 2 && localPos.x < mBlack / 2 && localPos.y > -mSpinet / 2 &&
            localPos.y < mSpinet / 2)
        {
            /*Debug.Log("localPos.x111111111111 == " + localPos.x + "     localPos.y == " + localPos.y + "      == " + (-mWidth / 2) + "       == " + mWidth / 2
                      + "             == " + -mHeight / 2 + "            == " + mHeight / 2);*/
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
                WeSpankRubble = true;
                InvokeRepeating(nameof(EraConspicuousJustice), 0f, 0.2f);
                // eraserStartEvent?.Invoke();
            }

            MyPit.Apply();
        }
    }

    double Band;
    double BandPig;
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
        //Debug.Log("当前百分比111: " + fate);
        if (Band >= Shun)
        {
            //Debug.LogError("uiTex" + uiTex.transform.name);
            WeCatRubble = true;
            CancelInvoke("GetTransparentPercent");
            UpPit.gameObject.SetActive(false);
            //触发结束事件
            Invoke("ShowScratchBonus", 0.5f);
        }
    }
    
    public void EraConspicuousJusticePig()
    {
        if (WeCatRubblePig)
        {
            return;
        }

        BandPig = TrashAPig / OwePluckAPig * 100;
        BandPig = (float) Math.Round(BandPig, 2);
        //Debug.Log("当前百分比222: " + fateTwo);
        if (BandPig >= ShunPig)
        {
            //Debug.LogError("uiTex" + uiTexTwo.transform.name);
            WeCatRubblePig = true;
            CancelInvoke("GetTransparentPercentTwo");
            UpPitPig.gameObject.SetActive(false);
            //触发结束事件
            Invoke("ShowScratchBonus", 0.5f);
        }
    }

    private void TuneDormantBylaw()
    {
        if (BandPig >= ShunPig && Band >= Shun)
        {
            BandPig = 0;
            Band = 0;
            AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_ThereSquash, new AnemoneWise(false));
        }
            
        //WordHikeScratchcardPanel.Instance.ShowScratchBar();
    }
}
